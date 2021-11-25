using BusinessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.FormsInventoryManager
{
    public partial class FormProductDetail : Form
    {
        private EntityProduct _product;
        private BusinessProduct _dbProduct = new BusinessProduct();
        private DataGridView _dataGridView;
        private Label _labelTotal;

        public FormProductDetail(EntityProduct product, DataGridView dataGridView, Label total)
        {
            InitializeComponent();
            _product = product;
            _dataGridView = dataGridView;
            _labelTotal = total;
        }

        private void FormProductDetail_Load(object sender, EventArgs e)
        {
            LabelName.Text = _product.Name;
            RichTextBoxDescription.Text = _product.Description;
            LabelNumberStock.Text = _product.Stock.ToString();
            LabelPrice.Text = _product.Price.ToString("C2");
            var memoryStream = new MemoryStream(_dbProduct.GetImage(_product.ProductID));
            PictureBoxProduct.Image = Image.FromStream(memoryStream);
            toolTip1.SetToolTip(LabelName, _product.Name);
            NumericUpDownProduct.Maximum = _product.Stock;
            NumericUpDownProduct.Minimum = _product.Stock == 0 ? 0 : 1;
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            addToDataGridView();
            Close();
        }

        private void addToDataGridView()
        {
            bool exist = false;
            int i = 0;
            foreach (DataGridViewRow row in _dataGridView.Rows)
            {
                if (Convert.ToInt32(row.Cells["ID"].Value) == _product.ProductID)
                {
                    exist = true;
                    i = row.Index;
                    break;
                }
            }
            if (exist)
            {
                var price = Convert.ToDecimal(LabelPrice.Text.Replace("$", ""));
                var last_quantity = Convert.ToInt32(_dataGridView.Rows[i].Cells["QTY"].Value);
                var last_total = last_quantity * price;
                var new_quantity = NumericUpDownProduct.Value + last_quantity;
                var new_total = new_quantity * price;
                _dataGridView.Rows[i].Cells["QTY"].Value = new_quantity;
                var total = Convert.ToDecimal(_labelTotal.Text.Replace("$", "")) - last_total + new_total;
                _labelTotal.Text = total.ToString("C2");
            }
            else
            {
                var price = Convert.ToDecimal(LabelPrice.Text.Replace("$", ""));
                var quantity = NumericUpDownProduct.Value;
                var totalPrice = price * quantity;
                _dataGridView.Rows.Add(LabelName.Text, quantity, LabelPrice.Text, _product.ProductID);
                var total = Convert.ToDecimal(_labelTotal.Text.Replace("$", "")) + totalPrice;
                _labelTotal.Text = total.ToString("C2");
            }
        }
    }
}
