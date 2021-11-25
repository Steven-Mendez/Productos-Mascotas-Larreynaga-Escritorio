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
    public partial class FormBill : Form
    {
        private BusinessSale _dbSale = new BusinessSale();
        private BusinessSaleDetail _dbSaleDetail = new BusinessSaleDetail();
        private EntityCustomer customer;
        private EntityEmployee employee;
        private string total;
        private DataGridView dataGridView;

        public FormBill(EntityCustomer customer, EntityEmployee employee, string total, DataGridView dataGridView)
        {
            InitializeComponent();
            this.customer = customer;
            this.employee = employee;
            this.total = total;
            this.dataGridView = dataGridView;

            customerTxt.Text = customer.FirstName;
            identificationTxt.Text = customer.Identification;
            EmployeeTxt.Text = employee.FirstName;
            MoneyTxt.Text = total;
        }

        private void FormBill_Load(object sender, EventArgs e)
        {

        }

        private void ButtonBill_Click(object sender, EventArgs e)
        {
            var res = _dbSale.Add(new EntitySale()
            {
                CustomerId = customer.CustomerId,
                EmployeeId = employee.EmployeeId,
                Date = DateTime.Now
            });
            if (res >= 1)
            {
                var saleID = _dbSale.LastIdentity();
                foreach (DataGridViewRow item in dataGridView.Rows)
                {
                    _dbSaleDetail.Add(new EntitySaleDetail()
                    {
                        SaleId = saleID,
                        ProductId = Convert.ToInt32(item.Cells[3].Value),
                        Quantity = Convert.ToInt32(item.Cells[1].Value),
                        Price = Convert.ToDecimal(item.Cells[2].Value.ToString().Replace("$", ""))
                    });
                }
                Close();
            }
            else
            {
                MessageBox.Show("Algo Salio mal!");
            }
        }
    }
}
