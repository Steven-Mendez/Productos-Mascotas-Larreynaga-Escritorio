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
    public partial class FormEditCustomer : Form
    {
        private EntityCustomer Customer;
        private BusinessCustomer _dbCustomer = new BusinessCustomer();
        private BusinessMunicipality _dbMunicipality = new BusinessMunicipality();
        private BusinessCustomerEmail _dbEmail = new BusinessCustomerEmail();
        private BusinessCustomerPhone _dbPhone = new BusinessCustomerPhone();

        public FormEditCustomer(EntityCustomer Customer)
        {
            InitializeComponent();
            this.Customer = Customer;
        }

        private void FormEditCustomer_Load(object sender, EventArgs e)
        {
            TextBoxID.Text = Customer.CustomerId.ToString();
            TextBoxFName.Text = Customer.FirstName;
            TextBoxSName.Text = Customer.SecondName;
            TextBoxFSurName.Text = Customer.FirstSurname;
            TextBoxSSurName.Text = Customer.SecondSurname;
            TextBoxIdentification.Text = Customer.Identification;
            DropdownMunicipality.DataSource = _dbMunicipality.Get();
            DropdownMunicipality.DisplayMember = "Municipio";
            DropdownMunicipality.ValueMember = "ID";
            DropdownMunicipality.SelectedIndex = Customer.MunicipalityId - 1;
            TextBoxStreetNumber.Text = Customer.StreetNumber.ToString();
            TextBoxStreetName.Text = Customer.StreetName;
            TextBoxAddress.Text = Customer.Address;
            DGEmails.DataSource = _dbEmail.Get(TextBoxID.Text, EntityCustomerEmail.EntityCustomerEmailAttribute.CustomerId);
            DGPhones.DataSource = _dbPhone.Get(TextBoxID.Text, EntityCustomerPhone.EntityCustomerPhoneAttribute.CustomerId);
        }

        private void ButtonAddEmail_Click(object sender, EventArgs e)
        {
            var add_email = new FormAddCustomerEmail(Convert.ToInt32(TextBoxID.Text));
            add_email.ShowDialog();
            DGEmails.DataSource = _dbEmail.Get(TextBoxID.Text, EntityCustomerEmail.EntityCustomerEmailAttribute.CustomerId);
        }

        private void ButtonAddPhone_Click(object sender, EventArgs e)
        {
            var add_phone = new FormAddCustomerPhone(Convert.ToInt32(TextBoxID.Text));
            add_phone.ShowDialog();
            DGPhones.DataSource = _dbPhone.Get(TextBoxID.Text, EntityCustomerPhone.EntityCustomerPhoneAttribute.CustomerId);
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            var Customer = new EntityCustomer()
            {
                CustomerId = Convert.ToInt32(TextBoxID.Text),
                MunicipalityId = Convert.ToInt32(DropdownMunicipality.SelectedValue),
                FirstName = TextBoxFName.Text,
                SecondName = TextBoxSName.Text,
                FirstSurname = TextBoxFSurName.Text,
                SecondSurname = TextBoxSSurName.Text,
                Identification = TextBoxIdentification.Text,
                Address = TextBoxAddress.Text,
                StreetNumber = Convert.ToInt32(TextBoxStreetNumber.Text),
                StreetName = Convert.ToString(TextBoxStreetName.Text)
            };
            if (_dbCustomer.Edit(Customer) >= 1)
            {
                Close();
            }
            else
            {
                MessageBox.Show("Algo salio mal!");
            }
        }

        private void DGPhones_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (DGPhones.SelectedRows.Count != 1)
            //{
            //    MessageBox.Show("Seleccione una fila antes de modificar.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            //DataGridViewCellCollection cells = DGPhones.CurrentRow.Cells;
            //var phone = new EntityCustomerPhone()
            //{
            //    PhoneId = Convert.ToInt32(cells[0].Value),
            //    CustomerId = Convert.ToInt32(TextBoxID.Text),
            //    Number = cells[1].Value.ToString()
            //};
            //var newPhone = new FormEditCustomerPhone(phone);
            //newPhone.ShowDialog();
            //DGPhones.DataSource = _dbPhone.Get(TextBoxID.Text, EntityCustomerPhone.EntityCustomerPhoneAttribute.CustomerId);
        }

        private void DGEmails_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (DGEmails.SelectedRows.Count != 1)
            //{
            //    MessageBox.Show("Seleccione una fila antes de modificar.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            //DataGridViewCellCollection cells = DGEmails.CurrentRow.Cells;
            //var email = new EntityCustomerEmail()
            //{
            //    EmailId = Convert.ToInt32(cells[0].Value),
            //    CustomerId = Convert.ToInt32(TextBoxID.Text),
            //    Email = cells[1].Value.ToString()
            //};
            //var newPhone = new FormEditCustomerEmail(email);
            //newPhone.ShowDialog();
            //DGEmails.DataSource = _dbEmail.Get(TextBoxID.Text, EntityCustomerEmail.EntityCustomerEmailAttribute.CustomerId);
        }

        private void DGPhones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGPhones.SelectedRows.Count != 1)
            {
                MessageBox.Show("Seleccione una fila antes de modificar.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewCellCollection cells = DGPhones.CurrentRow.Cells;
            var phone = new EntityCustomerPhone()
            {
                PhoneId = Convert.ToInt32(cells[0].Value),
                CustomerId = Convert.ToInt32(TextBoxID.Text),
                Number = cells[1].Value.ToString()
            };
            var newPhone = new FormEditCustomerPhone(phone);
            newPhone.ShowDialog();
            DGPhones.DataSource = _dbPhone.Get(TextBoxID.Text, EntityCustomerPhone.EntityCustomerPhoneAttribute.CustomerId);
        }

        private void DGEmails_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGEmails.SelectedRows.Count != 1)
            {
                MessageBox.Show("Seleccione una fila antes de modificar.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewCellCollection cells = DGEmails.CurrentRow.Cells;
            var email = new EntityCustomerEmail()
            {
                EmailId = Convert.ToInt32(cells[0].Value),
                CustomerId = Convert.ToInt32(TextBoxID.Text),
                Email = cells[1].Value.ToString()
            };
            var newPhone = new FormEditCustomerEmail(email);
            newPhone.ShowDialog();
            DGEmails.DataSource = _dbEmail.Get(TextBoxID.Text, EntityCustomerEmail.EntityCustomerEmailAttribute.CustomerId);
        }
    }
}
