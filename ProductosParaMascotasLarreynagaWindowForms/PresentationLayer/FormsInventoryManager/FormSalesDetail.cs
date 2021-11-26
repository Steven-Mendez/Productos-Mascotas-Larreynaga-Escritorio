using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;

namespace PresentationLayer.FormsInventoryManager
{
    public partial class FormSalesDetail : Form
    {
        private BusinessSaleDetail _dbSaleDetail = new BusinessSaleDetail();
        private string id;

        public FormSalesDetail(string id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void FormSalesDetail_Load(object sender, EventArgs e)
        {
            DG.DataSource = _dbSaleDetail.Get(id);
        }
    }
}
