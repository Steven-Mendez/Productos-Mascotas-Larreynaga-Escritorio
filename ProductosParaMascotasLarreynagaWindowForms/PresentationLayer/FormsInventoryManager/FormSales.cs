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

        private void DG_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DG.SelectedRows.Count != 1)
            {
                MessageBox.Show("Seleccione una fila antes de modificar.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewCellCollection cells = DG.CurrentRow.Cells;
            var form = new FormSalesDetail(Convert.ToString(cells[0].Value));
            form.ShowDialog();
        }

        private void TextBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DG.DataSource = _dbSales.Get(TextBoxSearch.Text);
                DG.Columns[4].DefaultCellStyle = new DataGridViewCellStyle() { Format = "C2" };
            }
        }
    }
}
