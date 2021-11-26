using BusinessLayer;
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
    public partial class FormSales : Form
    {
        private BusinessSale _dbSales = new BusinessSale();

        public FormSales()
        {
            InitializeComponent();
        }

        private void FormSales_Load(object sender, EventArgs e)
        {
            DG.DataSource = _dbSales.Get();
            DG.Columns[4].DefaultCellStyle = new DataGridViewCellStyle() { Format = "C2" };
        }
    }
}
