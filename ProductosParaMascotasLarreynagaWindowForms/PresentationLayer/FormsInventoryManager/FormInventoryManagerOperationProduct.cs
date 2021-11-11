using BusinessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static EntityLayer.EntityProductCategory;

namespace PresentationLayer.FormsInventoryManager
{
    public partial class FormInventoryManagerOperationProduct : Form
    {
        private enum Operation
        {
            Add,
            Edit
        }

        private Operation _operation;
        private BusinessProduct _dbProduct = new BusinessProduct();
        private BusinessProductCategory _dbProductCategory = new BusinessProductCategory();

        public FormInventoryManagerOperationProduct()
        {
            InitializeComponent();
            DropdownCategory.DataSource = _dbProductCategory.Get("", EntityProductCategoryAttribute.All, EntityOrderType.ASC);
            DropdownCategory.ValueMember = "ID";
            DropdownCategory.DisplayMember = "Categoria";
            _operation = Operation.Add;
            TextBoxID.Text = "ID-Auto-Generado";
            TextBoxID.ReadOnly = true;
        }

        public FormInventoryManagerOperationProduct(EntityProduct product)
        {
            InitializeComponent();
            DropdownCategory.DataSource = _dbProductCategory.Get("", EntityProductCategoryAttribute.All, EntityOrderType.ASC);
            DropdownCategory.ValueMember = "ID";
            DropdownCategory.DisplayMember = "Categoria";
            _operation = Operation.Edit;
            TextBoxID.Text = product.ProductID.ToString();
            TextBoxID.ReadOnly = true;
            DropdownCategory.SelectedIndex = product.CategoryID - 1;
            TextBoxName.Text = product.Name;
            TextBoxPrice.Text = product.Price.ToString();
            TextBoxDescription.Text = product.Description;
            var memoryStream = new MemoryStream(_dbProduct.GetImage(product.ProductID));
            PictureBoxProduct.Image = Image.FromStream(memoryStream);
            TextBoxName.Select(0, 0);
            TextBoxPrice.Select(0, 0);
            TextBoxDescription.Select(0, 0);
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (_operation == Operation.Add)
            {
                _add();
            }
            else
            {
                _edit();
            }
            Close();
        }

        private void _add()
        {
            var memoryStream = new MemoryStream();
            PictureBoxProduct.Image.Save(memoryStream, ImageFormat.Jpeg);
            var product = new EntityProduct()
            {
                CategoryID = Convert.ToInt32(DropdownCategory.SelectedValue),
                Name = TextBoxName.Text,
                Price = Convert.ToDecimal(TextBoxPrice.Text),
                Description = TextBoxDescription.Text,
                Image = memoryStream.GetBuffer()
            };

            var result = _dbProduct.Add(product);

            if (result > 0)
            {
                MessageBox.Show($"El producto {product.Name} ha sido añadido satisfactoriamente.", "Añadir Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show($"No se puede añadir el producto {product.Name}, verifica y vuelve a intentarlo,", "Añadir Producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void _edit()
        {
            var memoryStream = new MemoryStream();
            PictureBoxProduct.Image.Save(memoryStream, ImageFormat.Jpeg);
            var product = new EntityProduct()
            {
                ProductID = Convert.ToInt32(TextBoxID.Text),
                CategoryID = Convert.ToInt32(DropdownCategory.SelectedValue),
                Name = TextBoxName.Text,
                Price = Convert.ToDecimal(TextBoxPrice.Text),
                Description = TextBoxDescription.Text,
                Image = memoryStream.GetBuffer()
            };

            var result = _dbProduct.Edit(product);

            if (result > 0)
            {
                MessageBox.Show($"El producto {product.Name} ha sido editado satisfactoriamente.", "Editar Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show($"No se puede editar el producto {product.Name}, verifica y vuelve a intentarlo,", "Añadir Producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PictureBoxProduct_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            DialogResult dialogResult = openFileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                PictureBoxProduct.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void TextBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46)
            {
                e.Handled = true;
                return;
            }

            if (e.KeyChar == 46)
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }
        }
    }
}