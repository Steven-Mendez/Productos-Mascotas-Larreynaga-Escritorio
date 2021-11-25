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

        public ProductButton()
        {
            InitializeComponent();
        }
    }
}
