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
    public partial class FormEditCustomerEmail : Form
    {
        public BusinessCustomerEmail _dbEmail = new BusinessCustomerEmail();
        public BusinessCustomer _dbCustomer = new BusinessCustomer();
        private EntityCustomerEmail customerEmail;

        public FormEditCustomerEmail(EntityCustomerEmail customerEmail)
        {
            InitializeComponent();
            this.customerEmail = customerEmail;
        }

        private void FormEditCustomerEmail_Load(object sender, EventArgs e)
        {
            TextBoxID.Text = customerEmail.EmailId.ToString();
            DropdownEmployee.DataSource = _dbCustomer.Get();
            DropdownEmployee.ValueMember = "ID Cliente";
            DropdownEmployee.DisplayMember = "Nombre Completo";
            DropdownEmployee.SelectedIndex = customerEmail.CustomerId - 1;
            TextBoxEmail.Text = customerEmail.Email;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            var email = new EntityCustomerEmail()
            {
                EmailId = Convert.ToInt32(TextBoxID.Text),
                CustomerId = Convert.ToInt32(DropdownEmployee.SelectedValue),
                Email = TextBoxEmail.Text
            };
            if (_dbEmail.Edit(email) >= 1)
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
            var email = new EntityCustomerEmail()
            {
                EmailId = Convert.ToInt32(TextBoxID.Text),
                CustomerId = Convert.ToInt32(DropdownEmployee.SelectedValue),
                Email = TextBoxEmail.Text
            };
            if (_dbEmail.Delete(email) >= 1)
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
