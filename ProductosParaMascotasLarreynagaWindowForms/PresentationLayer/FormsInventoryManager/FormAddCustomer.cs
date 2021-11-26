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
    public partial class FormAddCustomer : Form
    {
        private BusinessCustomer _dbCustomer = new BusinessCustomer();
        private BusinessMunicipality _dbMunicipality = new BusinessMunicipality();

        public FormAddCustomer()
        {
            InitializeComponent();
        }

        private void FormAddCustomer_Load(object sender, EventArgs e)
        {
            TextBoxID.Text = "Auto-Generado";
            DropdownMunicipality.DataSource = _dbMunicipality.Get();
            DropdownMunicipality.DisplayMember = "Municipio";
            DropdownMunicipality.ValueMember = "ID";
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            var Customer = new EntityCustomer()
            {
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
            if (_dbCustomer.Add(Customer) >= 1)
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
