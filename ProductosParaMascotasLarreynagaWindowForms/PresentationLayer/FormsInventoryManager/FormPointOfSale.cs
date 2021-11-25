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
    public partial class FormPointOfSale : Form
    {
        private BusinessProduct _dbProduct = new BusinessProduct();

        public FormPointOfSale()
        {
            InitializeComponent();
        }

        private void FormPointOfSale_Load(object sender, EventArgs e)
        {
            var products = _dbProduct.List("", EntityProduct.EntityProductAttribute.All, EntityOrderType.ASC);
            _loadProduct(products);
        }

        private void _loadProduct(List<EntityProduct> products)
        {
            FlowPanelProducts.Controls.Clear();
            foreach (var product in products)
            {
                var memoryStream = new MemoryStream(_dbProduct.GetImage(product.ProductID));
                var button = new ProductButton(product, DataGridViewBill, LabelTotalMoney)
                {
                    TextName = product.Name,
                    TextPrice = product.Price.ToString("C2"),
                    ImageProduct = Image.FromStream(memoryStream)
                };
                FlowPanelProducts.Controls.Add(button);
            }
        }

        private void TextBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var products = _dbProduct.List(TextBoxSearch.Text, EntityProduct.EntityProductAttribute.All, EntityOrderType.ASC);
                _loadProduct(products);
            }
        }

        private void ButtonBill_Click(object sender, EventArgs e)
        {
            var selectCustomer = new FormSelectCustomer(LabelTotalMoney.Text, DataGridViewBill);
            selectCustomer.ShowDialog();
            var products = _dbProduct.List(TextBoxSearch.Text, EntityProduct.EntityProductAttribute.All, EntityOrderType.ASC);
            _loadProduct(products);
        }

        private void ButtonClearOne_Click(object sender, EventArgs e)
        {
            try
            {
                var row = DataGridViewBill.CurrentRow;
                var quantity = Convert.ToInt32(row.Cells["QTY"].Value);
                if (quantity < 1)
                {
                    DataGridViewBill.Rows.RemoveAt(row.Index);
                }
                else
                {
                    row.Cells["QTY"].Value = (quantity - 1).ToString();
                }
            }
            catch (Exception)
            {
            }
            
        }

        private void ButtonClearAll_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewBill.Rows.RemoveAt(DataGridViewBill.CurrentRow.Index);
            }
            catch (Exception)
            {
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            DataGridViewBill.Rows.Clear();
            LabelTotalMoney.Text = "$0.00";
        }
    }
}
