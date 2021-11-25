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

namespace PresentationLayer.FormsInventoryManager
{
    public partial class FormSelectCustomer : Form
    {
        BusinessCustomer _dbCustomers = new BusinessCustomer();
        private string total;
        private DataGridView dataGridView;

        public FormSelectCustomer(string total, DataGridView dataGridView)
        {
            InitializeComponent();
            this.total = total;
            this.dataGridView = dataGridView;
        }

        private void FormSelectCustomer_Load(object sender, EventArgs e)
        {
            DataGridViewCustomers.DataSource = _dbCustomers.Get();
        }

        private void TextBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataGridViewCustomers.DataSource = _dbCustomers.Get(TextBoxSearch.Text);
            }
        }

        private void ButtonSelect_Click(object sender, EventArgs e)
        {
            DataGridViewCellCollection cells = DataGridViewCustomers.CurrentRow.Cells;
            var customerId = new EntityCustomer()
            {
                CustomerId = Convert.ToInt32(cells[0].Value),
                FirstName = Convert.ToString(cells[1].Value),
                Identification = Convert.ToString(cells[2].Value)
            };
            var employee = new FormSelectEmployee(customerId, total, dataGridView);
            Visible = false;
            employee.ShowDialog();
            Close();
        }
    }
}
