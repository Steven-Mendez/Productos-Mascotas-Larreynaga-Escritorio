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
    public partial class FormAddCustomerEmail : Form
    {
        public BusinessCustomerEmail _dbEmail = new BusinessCustomerEmail();
        public BusinessCustomer _dbCustomer = new BusinessCustomer();
        private int CustomerId;

        public FormAddCustomerEmail(int CustomerId)
        {
            InitializeComponent();
            this.CustomerId = CustomerId;
        }

        private void FormAddCustomerEmail_Load(object sender, EventArgs e)
        {
            TextBoxID.Text = "Auto-Generado";
            DropdownNames.DataSource = _dbCustomer.Get();
            DropdownNames.ValueMember = "ID Cliente";
            DropdownNames.DisplayMember = "Nombre Completo";
            DropdownNames.SelectedIndex = CustomerId - 1;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            var email = new EntityCustomerEmail()
            {
                CustomerId = Convert.ToInt32(DropdownNames.SelectedValue),
                Email = TextBoxEmail.Text
            };
            if (_dbEmail.Add(email) >= 1)
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
