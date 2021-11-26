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
    public partial class FormAddEmployeeEmail : Form
    {
        public BusinessEmployeeEmail _dbEmail = new BusinessEmployeeEmail();
        public BusinessEmployee _dbEmployee = new BusinessEmployee();
        private int EmployeeId;

        public FormAddEmployeeEmail(int EmployeeId)
        {
            InitializeComponent();
            this.EmployeeId = EmployeeId;
        }

        private void FormAddEmployeeEmail_Load(object sender, EventArgs e)
        {
            TextBoxID.Text = "Auto-Generado";
            DropdownEmployee.DataSource = _dbEmployee.Get();
            DropdownEmployee.ValueMember = "ID";
            DropdownEmployee.DisplayMember = "Nombre Completo";
            DropdownEmployee.SelectedIndex = EmployeeId - 1;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            var email = new EntityEmployeeEmail()
            {
                EmployeeId = Convert.ToInt32(DropdownEmployee.SelectedValue),
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
