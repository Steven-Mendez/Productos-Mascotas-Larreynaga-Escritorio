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
using static EntityLayer.EntityProductCategory;

namespace PresentationLayer.FormsInventoryManager
{
    public partial class FormCategoryManager : Form
    {
        private BusinessProductCategory _dbProductCategory = new BusinessProductCategory();
        private EntityProductCategoryAttribute _searchBy = EntityProductCategoryAttribute.All;
        private EntityOrderType _orderType = EntityOrderType.ASC;
        private List<(PictureBox, Image, Image)> _searchImageButtons = new List<(PictureBox, Image, Image)>();
        private List<(PictureBox, Image, Image)> _orderImageButtons = new List<(PictureBox, Image, Image)>();
        private Operation _operation = Operation.None;

        public FormCategoryManager()
        {
            InitializeComponent();
            _setDataGridView();
            _searchImageButtons.Add((PictureBoxRefresh, InventoryManager.inventory_management_update_sage_green, InventoryManager.inventory_management_update_green));
            _searchImageButtons.Add((PictureBoxID, InventoryManager.inventory_management_id_button_sage_green, InventoryManager.inventory_management_id_button_green));
            _searchImageButtons.Add((PictureBoxCategory, InventoryManager.inventory_management_category_sage_green, InventoryManager.inventory_management_category_green));
            _orderImageButtons.Add((PictureBoxAscending, InventoryManager.inventory_management_sort_ascending_sage_green, InventoryManager.inventory_management_sort_ascending_green));
            _orderImageButtons.Add((PictureBoxDescending, InventoryManager.inventory_management_sort_descending_sage_green, InventoryManager.inventory_management_sort_descending_green));
        }

        private void DataGridViewCategoryManagament_SelectionChanged(object sender, EventArgs e)
        {
            _operationCancelOrSave(Operation.Cancel);
            if (DataGridViewCategoryManagament.Rows.Count > 0)
            {
                var row = DataGridViewCategoryManagament.CurrentRow.Cells;
                TextBoxID.Text = row["ID"].Value.ToString();
                TextBoxName.Text = row["Categoria"].Value.ToString();
            }
        }

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            _operationCancelOrSave(Operation.Cancel);
            _setDataGridView(TextBoxSearch.Text);
        }

        private void PictureBoxRefresh_Click(object sender, EventArgs e)
        {
            _setSearchBy(sender as PictureBox, EntityProductCategoryAttribute.All);
            _setOrderType(PictureBoxAscending, EntityOrderType.ASC);
        }

        private void PictureBoxID_Click(object sender, EventArgs e)
        {
            _setSearchBy(sender as PictureBox, EntityProductCategoryAttribute.CategoryID);
        }

        private void PictureBoxCategory_Click(object sender, EventArgs e)
        {
            _setSearchBy(sender as PictureBox, EntityProductCategoryAttribute.Name);
        }

        private void PictureBoxAscending_Click(object sender, EventArgs e)
        {
            _setOrderType(PictureBoxAscending, EntityOrderType.ASC);
        }

        private void PictureBoxDescending_Click(object sender, EventArgs e)
        {
            _setOrderType(PictureBoxDescending, EntityOrderType.DESC);
        }

        private void _setDataGridView(string search = "")
        {
            DataGridViewCategoryManagament.DataSource = _dbProductCategory.Get(search, _searchBy, _orderType);
        }

        private void _setSearchBy(PictureBox button, EntityProductCategoryAttribute attribute)
        {
            if (attribute == _searchBy)
            {
                _searchBy = EntityProductCategoryAttribute.All;
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

        private void _setOrderType(PictureBox button, EntityOrderType orderType)
        {
            if (orderType != _orderType)
            {
                _orderType = orderType;
                _orderImageButtons.ForEach(b =>
                {
                    if (!b.Item1.Equals(button))
                    {
                        b.Item1.Image = b.Item2;
                    }
                    else
                    {
                        b.Item1.Image = b.Item3;
                    }
                });
                _setDataGridView(TextBoxSearch.Text);
            }
        }

        private void PictureBoxAdd_Click(object sender, EventArgs e)
        {
            _operationAddOrEdit(sender as PictureBox, Operation.Add);
            TextBoxID.Text = "Auto-Generado";
            TextBoxName.Text = "";
            TextBoxName.ReadOnly = false;
        }

        private void PictureBoxEdit_Click(object sender, EventArgs e)
        {
            _operationAddOrEdit(sender as PictureBox, Operation.Edit);
            TextBoxName.Select(0, 0);
            TextBoxName.ReadOnly = false;
        }

        private void PictureBoxDelete_Click(object sender, EventArgs e)
        {
            if (DataGridViewCategoryManagament.Rows.Count > 0)
            {
                var row = DataGridViewCategoryManagament.CurrentRow.Cells;
                var category = new EntityProductCategory()
                {
                    CategoryID = Convert.ToInt32(row["ID"].Value),
                    Name = row["Categoria"].Value.ToString()
                };
                var rowsAffected = _dbProductCategory.Delete(category);
                if (rowsAffected > 0)
                {
                    _setDataGridView(TextBoxSearch.Text);
                    _operationCancelOrSave(Operation.Cancel);
                }
            }
        }

        private void PictureBoxSave_Click(object sender, EventArgs e)
        {
            if (_operation == Operation.Add)
            {
                var category = new EntityProductCategory()
                {
                    Name = TextBoxName.Text
                };
                var rowsAffected = _dbProductCategory.Add(category);
                if (rowsAffected > 0)
                {
                    MessageBox.Show($"La categoria {category.Name} ha sido agregada con exito.", "Categorias", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _setDataGridView();
                    _operationCancelOrSave(Operation.Save);
                }
                else
                {
                    MessageBox.Show($"Ha ocurrido un error y no fue posible agregar la categoría.", "Categorias", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (_operation == Operation.Edit)
            {
                var category = new EntityProductCategory()
                {
                    CategoryID = Convert.ToInt32(TextBoxID.Text),
                    Name = TextBoxName.Text
                };
                var rowsAffected = _dbProductCategory.Edit(category);
                if (rowsAffected > 0)
                {
                    MessageBox.Show($"La categoria {category.Name} ha sido editada con exito.", "Categorias", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _setDataGridView();
                    _operationCancelOrSave(Operation.Save);
                }
                else
                {
                    MessageBox.Show($"Ha ocurrido un error y no fue posible editar la categoría.", "Categorias", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void PictureBoxCancel_Click(object sender, EventArgs e)
        {
            _operationCancelOrSave(Operation.Cancel);
        }

        private void _operationAddOrEdit(PictureBox sender, Operation operation)
        {
            _operation = operation;
            sender.Enabled = false;
            if (_operation == Operation.Add)
            {
                sender.Image = InventoryManager.inventory_managment_folder_add_filled;
                PictureBoxEdit.Enabled = false;
                PictureBoxEdit.Image = InventoryManager.inventory_managment_folder_open_filled;
            }
            else if (_operation != Operation.Cancel && _operation != Operation.Save)
            {
                sender.Image = InventoryManager.inventory_managment_folder_open_filled;
                PictureBoxAdd.Enabled = false;
                PictureBoxAdd.Image = InventoryManager.inventory_managment_folder_add_filled;
            }
            PictureBoxSave.Enabled = PictureBoxCancel.Enabled = true;
            PictureBoxSave.Image = InventoryManager.inventory_management_content_save_green;
            PictureBoxCancel.Image = InventoryManager.inventory_managment_folder_cancel_green;
        }

        private void _operationCancelOrSave(Operation operation)
        {
            PictureBoxSave.Enabled = PictureBoxCancel.Enabled = false;
            PictureBoxSave.Image = InventoryManager.inventory_management_content_save;
            PictureBoxCancel.Image = InventoryManager.inventory_managment_folder_cancel;
            PictureBoxAdd.Enabled = PictureBoxEdit.Enabled = true;
            PictureBoxEdit.Image = InventoryManager.inventory_managment_folder_open_filled_green;
            PictureBoxAdd.Image = InventoryManager.inventory_managment_folder_add_filled_green;
            TextBoxID.Text = TextBoxName.Text = "";
            TextBoxID.ReadOnly = TextBoxName.ReadOnly = true;
        }

        private enum Operation
        {
            Add,
            Edit,
            Cancel,
            Save,
            None
        }
    }
}
