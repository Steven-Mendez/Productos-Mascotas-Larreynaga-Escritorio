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
    public partial class FormEditEmployee : Form
    {
        private EntityEmployee employee;
        private BusinessEmployee _dbEmployee = new BusinessEmployee();
        private BusinessBranchOffice _dbBranchOffice = new BusinessBranchOffice();
        private BusinessEmployeePosition _dbEmployeePosition = new BusinessEmployeePosition();
        private BusinessMunicipality _dbMunicipality = new BusinessMunicipality();
        private BusinessEmployeeEmail _dbEmail = new BusinessEmployeeEmail();
        private BusinessEmployeePhone _dbPhone = new BusinessEmployeePhone();

        public FormEditEmployee(EntityEmployee employee)
        {
            InitializeComponent();
            this.employee = employee;
        }

        private void FormEditEmployee_Load(object sender, EventArgs e)
        {
            TextBoxID.Text = employee.EmployeeId.ToString();
            TextBoxFName.Text = employee.FirstName;
            TextBoxSName.Text = employee.SecondName;
            TextBoxFSurName.Text = employee.FirstSurname;
            TextBoxSSurName.Text = employee.SecondSurname;
            TextBoxIdentification.Text = employee.Identification;
            DropdownPosition.DataSource = _dbEmployeePosition.Get();
            DropdownPosition.DisplayMember = "Cargo";
            DropdownPosition.ValueMember = "ID";
            DropdownPosition.SelectedIndex = employee.EmployeePositionId - 1;
            DropdownBranchOffice.DataSource = _dbBranchOffice.Get();
            DropdownBranchOffice.DisplayMember = "Sucursal";
            DropdownBranchOffice.ValueMember = "ID";
            DropdownBranchOffice.SelectedIndex = employee.BranchOfficeId - 1;
            DropdownMunicipality.DataSource = _dbMunicipality.Get();
            DropdownMunicipality.DisplayMember = "Municipio";
            DropdownMunicipality.ValueMember = "ID";
            DropdownMunicipality.SelectedIndex = employee.MunicipalityId - 1;
            TextBoxStreetNumber.Text = employee.StreetNumber.ToString();
            TextBoxStreetName.Text = employee.StreetName;
            TextBoxAddress.Text = employee.Address;
            DGEmails.DataSource = _dbEmail.Get(TextBoxID.Text, EntityEmployeeEmail.EntityEmployeeEmailAttribute.EmployeeId);
            DGPhones.DataSource = _dbPhone.Get(TextBoxID.Text, EntityEmployeePhone.EntityEmployeePhoneAttribute.EmployeeId);
        }

        private void ButtonAddPhone_Click(object sender, EventArgs e)
        {
            var add_phone = new FormAddEmployeePhone(Convert.ToInt32(TextBoxID.Text));
            add_phone.ShowDialog();
            DGPhones.DataSource = _dbPhone.Get(TextBoxID.Text, EntityEmployeePhone.EntityEmployeePhoneAttribute.EmployeeId);
        }

        private void ButtonAddEmail_Click(object sender, EventArgs e)
        {
            var add_email = new FormAddEmployeeEmail(Convert.ToInt32(TextBoxID.Text));
            add_email.ShowDialog();
            DGEmails.DataSource = _dbEmail.Get(TextBoxID.Text, EntityEmployeeEmail.EntityEmployeeEmailAttribute.EmployeeId);
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            var employee = new EntityEmployee()
            {
                EmployeeId = Convert.ToInt32(TextBoxID.Text),
                EmployeePositionId = Convert.ToInt32(DropdownPosition.SelectedValue),
                BranchOfficeId = Convert.ToInt32(DropdownBranchOffice.SelectedValue),
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
            if (_dbEmployee.Edit(employee) >= 1)
            {
                Close();
            }
            else
            {
                MessageBox.Show("Algo salio mal!");
            }
        }

        private void DGPhones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGPhones.SelectedRows.Count != 1)
            {
                MessageBox.Show("Seleccione una fila antes de modificar.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewCellCollection cells = DGPhones.CurrentRow.Cells;
            var phone = new EntityEmployeePhone()
            {
                PhoneId = Convert.ToInt32(cells[0].Value),
                EmployeeId = Convert.ToInt32(TextBoxID.Text),
                Number = cells[1].Value.ToString()
            };
            var newPhone = new FormEditEmployeePhone(phone);
            newPhone.ShowDialog();
            DGPhones.DataSource = _dbPhone.Get(TextBoxID.Text, EntityEmployeePhone.EntityEmployeePhoneAttribute.EmployeeId);
        }

        private void DGEmails_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGEmails.SelectedRows.Count != 1)
            {
                MessageBox.Show("Seleccione una fila antes de modificar.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewCellCollection cells = DGEmails.CurrentRow.Cells;
            var email = new EntityEmployeeEmail()
            {
                EmailId = Convert.ToInt32(cells[0].Value),
                EmployeeId = Convert.ToInt32(TextBoxID.Text),
                Email = cells[1].Value.ToString()
            };
            var newEmail = new FormEditEmployeeEmail(email);
            newEmail.ShowDialog();
            DGEmails.DataSource = _dbEmail.Get(TextBoxID.Text, EntityEmployeeEmail.EntityEmployeeEmailAttribute.EmployeeId);
        }
    }
}
