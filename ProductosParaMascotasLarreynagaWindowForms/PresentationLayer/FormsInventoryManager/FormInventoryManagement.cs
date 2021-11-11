using Bunifu.UI.WinForms;
using BusinessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.FormsInventoryManager
{
    public partial class FormInventoryManagement : Form
    {
        private BusinessProduct _dbProduct = new BusinessProduct();
        private EntityProductAttribute _searchBy = EntityProductAttribute.All;
        private List<(BunifuImageButton, Image, Image)> _searchImageButtons = new List<(BunifuImageButton, Image, Image)>();
        private EntityOrderType _orderType = EntityOrderType.ASC;
        private List<(BunifuImageButton, Image, Image)> _orderImageButtons = new List<(BunifuImageButton, Image, Image)>();

        public FormInventoryManagement()
        {
            InitializeComponent();
            _searchImageButtons.Add((ImageButtonSearchByID, ImageButtonSearchByID.Image, InventoryManager.inventory_management_id_button_green));
            _searchImageButtons.Add((ImageButtonSearchByProductName, ImageButtonSearchByProductName.Image, InventoryManager.inventory_management_bag_fill_green));
            _searchImageButtons.Add((ImageButtonDescription, ImageButtonDescription.Image, InventoryManager.inventory_management_description_green));
            _searchImageButtons.Add((ImageButtonSearchByCategory, ImageButtonSearchByCategory.Image, InventoryManager.inventory_management_category_green));
            _searchImageButtons.Add((ImageButtonSearchBySalePrice, ImageButtonSearchBySalePrice.Image, InventoryManager.inventory_management_pricealt_green));
            _searchImageButtons.Add((ImageButtonSearchByStock, ImageButtonSearchByStock.Image, InventoryManager.inventory_management_stock_green));

            _orderImageButtons.Add((ImageButtonOrderAscending, InventoryManager.inventory_management_sort_ascending_green, InventoryManager.inventory_management_sort_ascending_ebony));
            _orderImageButtons.Add((ImageButtonOrderDescending, InventoryManager.inventory_management_sort_descending_green, InventoryManager.inventory_management_sort_descending_ebony));
        }

        private void FormInventoryManagement_Load(object sender, EventArgs e)
        {
            _setDataGridView("");
        }

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            _setDataGridView(TextBoxSearch.Text);
        }

        private void ImageButtonRefresh_Click(object sender, EventArgs e)
        {
            _setSearchBy(sender as BunifuImageButton, EntityProductAttribute.All);
            ImageButtonOrderAscending.PerformClick();
        }

        private void ImageButtonSearchByID_Click(object sender, EventArgs e)
        {
            _setSearchBy(sender as BunifuImageButton, EntityProductAttribute.Id);
        }

        private void ImageButtonSearchByProductName_Click(object sender, EventArgs e)
        {
            _setSearchBy(sender as BunifuImageButton, EntityProductAttribute.Name);
        }

        private void ImageButtonDescription_Click(object sender, EventArgs e)
        {
            _setSearchBy(sender as BunifuImageButton, EntityProductAttribute.Description);
        }

        private void ImageButtonSearchByCategory_Click(object sender, EventArgs e)
        {
            _setSearchBy(sender as BunifuImageButton, EntityProductAttribute.Category);
        }

        private void ImageButtonSearchBySalePrice_Click(object sender, EventArgs e)
        {
            _setSearchBy(sender as BunifuImageButton, EntityProductAttribute.Price);
        }

        private void ImageButtonSearchByStock_Click(object sender, EventArgs e)
        {
            _setSearchBy(sender as BunifuImageButton, EntityProductAttribute.Stock);
        }

        private void ImageButtonOrderAscending_Click(object sender, EventArgs e)
        {
            _setOrderType(sender as BunifuImageButton, EntityOrderType.ASC);
        }

        private void ImageButtonOrderDescending_Click(object sender, EventArgs e)
        {
            _setOrderType(sender as BunifuImageButton, EntityOrderType.DESC);
        }

        private void ImageButtonAddProduct_Click(object sender, EventArgs e)
        {
            var form = new FormInventoryManagerOperationProduct();
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                _setDataGridView(TextBoxSearch.Text);
            }
        }

        private void ImageButtonEditProduct_Click(object sender, EventArgs e)
        {
            if (DataGridViewInventoryManagament.SelectedRows.Count != 1)
            {
                MessageBox.Show("Seleccione una fila antes de modificar.", "Gestión de Inventario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewCellCollection cells = DataGridViewInventoryManagament.CurrentRow.Cells;
            var product = new EntityProduct()
            {
                ProductID = Convert.ToInt32(cells["ID"].Value),
                CategoryID = Convert.ToInt32(new BusinessProductCategory().Get(cells["Categoria"].Value.ToString(), EntityProductCategoryAttribute.Name, EntityOrderType.ASC).Rows[0][0]),
                Name = cells["Nombre"].Value.ToString(),
                Description = cells["Descripción"].Value.ToString(),
                Price = Convert.ToDecimal(cells["Precio"].Value.ToString().Replace("$", ""))
            };
            var form = new FormInventoryManagerOperationProduct(product);
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                _setDataGridView(TextBoxSearch.Text);
            }
        }

        private void ImageButtonDelete_Click(object sender, EventArgs e)
        {
            if (DataGridViewInventoryManagament.SelectedRows.Count != 1)
            {
                MessageBox.Show("Seleccione una fila antes de modificar.", "Gestión de Inventario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewCellCollection cells = DataGridViewInventoryManagament.CurrentRow.Cells;

            var product = new EntityProduct()
            {
                ProductID = Convert.ToInt32(cells["ID"].Value),
                CategoryID = Convert.ToInt32(new BusinessProductCategory().Get(cells["Categoria"].Value.ToString(), EntityProductCategoryAttribute.Name, EntityOrderType.ASC).Rows[0][0]),
                Name = cells["Nombre"].Value.ToString(),
                Description = cells["Descripción"].Value.ToString(),
                Price = Convert.ToDecimal(cells["Precio"].Value.ToString().Replace("$", ""))
            };

            var dbProduct = new BusinessProduct();
            var rowsAffected = dbProduct.Delete(product);

            if (rowsAffected <= 0)
            {
                MessageBox.Show("No fue posible eliminar el producto seleccionado.", "Gestión de Inventario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                _setDataGridView(TextBoxSearch.Text);
            }
        }

        private void ImageButtonCategories_Click(object sender, EventArgs e)
        {
            var form = new FormCategoryManager();
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                _setDataGridView(TextBoxSearch.Text);
            }
            else
            {
                _setDataGridView(TextBoxSearch.Text);
            }
        }

        private void _setSearchBy(BunifuImageButton button, EntityProductAttribute attribute)
        {
            if (attribute == _searchBy)
            {
                _searchBy = EntityProductAttribute.All;
                _searchImageButtons.ForEach(b =>
                {
                    if (b.Item1.Equals(button))
                        b.Item1.Image = b.Item3;
                });
            }
            else
            {
                _searchBy = attribute;
                _searchImageButtons.ForEach(b =>
                {
                    if (b.Item1.Equals(button))
                        b.Item1.Image = b.Item3;
                    else
                        b.Item1.Image = b.Item2;
                });
            }
            _setDataGridView(TextBoxSearch.Text);
        }

        private void _setOrderType(BunifuImageButton button, EntityOrderType orderType)
        {
            if (orderType != _orderType)
            {
                _orderType = orderType;
                _orderImageButtons.ForEach(b =>
                {
                    if (!b.Item1.Equals(button))
                    {
                        b.Item1.Image = b.Item3;
                    }
                    else
                    {
                        b.Item1.Image = b.Item2;
                    }
                });
                _setDataGridView(TextBoxSearch.Text);
            }
        }

        private void _setDataGridView(string search)
        {
            DataGridViewInventoryManagament.DataSource = _dbProduct.Get(search, _searchBy, _orderType);
            DataGridViewInventoryManagament.Columns[4].DefaultCellStyle = new DataGridViewCellStyle() { Format = "C2" };
        }

        private void DataGridViewInventoryManagament_DoubleClick(object sender, EventArgs e)
        {
            ImageButtonEditProduct.PerformClick();
        }
    }
}
