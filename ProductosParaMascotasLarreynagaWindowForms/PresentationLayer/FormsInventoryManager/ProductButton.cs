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
    public partial class ProductButton : UserControl
    {
        private DataGridView _dataGridView;
        private Label _labelTotal;

        public string TextName
        {
            get { return LabelName.Text; }
            set { LabelName.Text = value; }
        }

        public string TextPrice
        {
            get { return LabelPrice.Text; }
            set { LabelPrice.Text = value; }
        }

        public Image ImageProduct
        {
            get { return PictureBoxProduct.Image; }
            set { PictureBoxProduct.Image = value; }
        }

        public EntityProduct Product { get; set; }

        public ProductButton(EntityProduct product, DataGridView dataGridView, Label total)
        {
            InitializeComponent();
            _dataGridView = dataGridView;
            _labelTotal = total;
            Product = product;
            toolTip1.SetToolTip(LabelName, product.Name);
        }

        private void ButtonDetails_Click(object sender, EventArgs e)
        {
            var form = new FormProductDetail(Product, _dataGridView, _labelTotal);
            form.ShowDialog();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            addToDataGridView();
        }

        private void addToDataGridView()
        {
            bool exist = false;
            int i = 0;
            foreach (DataGridViewRow row in _dataGridView.Rows)
            {
                if (Convert.ToInt32(row.Cells["ID"].Value) == Product.ProductID)
                {
                    exist = true;
                    i = row.Index;
                    break;
                }
            }
            if (exist)
            {
                var quantity = 1 + Convert.ToInt32(_dataGridView.Rows[i].Cells["QTY"].Value);

                _dataGridView.Rows[i].Cells["QTY"].Value = quantity;
                var total = Convert.ToDecimal(_labelTotal.Text.Replace("$", "")) + Convert.ToDecimal(TextPrice.Replace("$", ""));
                _labelTotal.Text = total.ToString("C2");
            }
            else
            {
                _dataGridView.Rows.Add(TextName, 1, TextPrice, Product.ProductID);
                var total = Convert.ToDecimal(_labelTotal.Text.Replace("$", "")) + Convert.ToDecimal(TextPrice.Replace("$", ""));
                _labelTotal.Text = total.ToString("C2");
            }
        }
    }
}
