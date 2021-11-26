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
    public partial class FormAddEmployee : Form
    {
        private BusinessEmployee _dbEmployee = new BusinessEmployee();
        private BusinessBranchOffice _dbBranchOffice = new BusinessBranchOffice();
        private BusinessEmployeePosition _dbEmployeePosition = new BusinessEmployeePosition();
        private BusinessMunicipality _dbMunicipality = new BusinessMunicipality();

        public FormAddEmployee()
        {
            InitializeComponent();
        }

        private void FormAddEmployee_Load(object sender, EventArgs e)
        {
            DropdownPosition.DataSource = _dbEmployeePosition.Get();
            DropdownPosition.DisplayMember = "Cargo";
            DropdownPosition.ValueMember = "ID";
            DropdownBranchOffice.DataSource = _dbBranchOffice.Get();
            DropdownBranchOffice.DisplayMember = "Sucursal";
            DropdownBranchOffice.ValueMember = "ID";
            DropdownMunicipality.DataSource = _dbMunicipality.Get();
            DropdownMunicipality.DisplayMember = "Municipio";
            DropdownMunicipality.ValueMember = "ID";
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            EntityEmployee employee = null;
            try
            {
                employee = new EntityEmployee()
                {
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
                    StreetName = TextBoxStreetName.Text
                };
            }
            catch
            {
            }
            if (_dbEmployee.Add(employee) >= 1)
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
