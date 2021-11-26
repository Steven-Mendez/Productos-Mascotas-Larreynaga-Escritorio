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
    public partial class FormEditCustomerPhone : Form
    {
        public BusinessCustomerPhone _dbPhone = new BusinessCustomerPhone();
        public BusinessCustomer _dbEmployee = new BusinessCustomer();
        private EntityCustomerPhone customerPhone;

        public FormEditCustomerPhone(EntityCustomerPhone customerPhone)
        {
            InitializeComponent();
            this.customerPhone = customerPhone;
        }

        private void FormEditCustomerPhone_Load(object sender, EventArgs e)
        {
            TextBoxID.Text = customerPhone.PhoneId.ToString();
            DropdownEmployee.DataSource = _dbEmployee.Get();
            DropdownEmployee.ValueMember = "ID Cliente";
            DropdownEmployee.DisplayMember = "Nombre Completo";
            DropdownEmployee.SelectedIndex = customerPhone.CustomerId - 1;
            TextBoxPhone.Text = customerPhone.Number;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            var phone = new EntityCustomerPhone()
            {
                PhoneId = Convert.ToInt32(TextBoxID.Text),
                CustomerId = Convert.ToInt32(DropdownEmployee.SelectedValue),
                Number = TextBoxPhone.Text
            };
            if (_dbPhone.Edit(phone) >= 1)
            {
                Close();
            }
            else
            {
                MessageBox.Show("Algo salio mal!");
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            var phone = new EntityCustomerPhone()
            {
                PhoneId = Convert.ToInt32(TextBoxID.Text),
                CustomerId = Convert.ToInt32(DropdownEmployee.SelectedValue),
                Number = TextBoxPhone.Text
            };
            if (_dbPhone.Delete(phone) >= 1)
            {
                Close();
            }
            else
            {
                MessageBox.Show("Algo salio mal!");
            }
        }
    }
}
