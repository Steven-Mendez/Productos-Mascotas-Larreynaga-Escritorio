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
                var button = new ProductButton()
                {
                    Product = product,
                    TextName = product.Name,
                    TextPrice = product.Price.ToString("C2"),
                    ImageProduct = Image.FromStream(memoryStream)
            };
                FlowPanelProducts.Controls.Add(button);
            }
        }
    }
}
