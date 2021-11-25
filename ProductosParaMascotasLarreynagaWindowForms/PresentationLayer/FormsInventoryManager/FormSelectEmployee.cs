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
    public partial class FormSelectEmployee : Form
    {
        private EntityCustomer _customerId;
        private string total;
        BusinessEmployee _dbEmployee = new BusinessEmployee();
        private DataGridView dataGridView;
        public FormSelectEmployee(EntityCustomer customerId, string total, DataGridView dataGridView)
        {
            InitializeComponent();
            _customerId = customerId;
            this.total = total;
            this.dataGridView = dataGridView;
        }

        private void ButtonSelect_Click(object sender, EventArgs e)
        {
            DataGridViewCellCollection cells = DataGridViewEmployee.CurrentRow.Cells;
            var employeeId = new EntityEmployee()
            {
                EmployeeId = Convert.ToInt32(cells[0].Value),
                FirstName = Convert.ToString(cells[3].Value)
            };
            var bill = new FormBill(_customerId, employeeId, total, dataGridView);
            Visible = false;
            bill.ShowDialog();
            Close();
        }

        private void FormSelectEmployee_Load(object sender, EventArgs e)
        {
            DataGridViewEmployee.DataSource = _dbEmployee.Get();
        }

        private void TextBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataGridViewEmployee.DataSource = _dbEmployee.Get(TextBoxSearch.Text);
            }
        }
    }
}
