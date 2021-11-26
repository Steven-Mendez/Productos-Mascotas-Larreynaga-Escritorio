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
    public partial class FormEditEmployeeEmail : Form
    {
        public BusinessEmployeeEmail _dbEmail = new BusinessEmployeeEmail();
        public BusinessEmployee _dbEmployee = new BusinessEmployee();
        private EntityEmployeeEmail employeeEmail;

        public FormEditEmployeeEmail(EntityEmployeeEmail employeeEmail)
        {
            InitializeComponent();
            this.employeeEmail = employeeEmail;
        }

        private void FormEditEmployeeEmail_Load(object sender, EventArgs e)
        {
            TextBoxID.Text = employeeEmail.EmailId.ToString();
            DropdownEmployee.DataSource = _dbEmployee.Get();
            DropdownEmployee.ValueMember = "ID";
            DropdownEmployee.DisplayMember = "Nombre Completo";
            DropdownEmployee.SelectedIndex = employeeEmail.EmployeeId - 1;
            TextBoxEmail.Text = employeeEmail.Email;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            var email = new EntityEmployeeEmail()
            {
                EmailId = Convert.ToInt32(TextBoxID.Text),
                EmployeeId = Convert.ToInt32(DropdownEmployee.SelectedValue),
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
            var email = new EntityEmployeeEmail()
            {
                EmailId = Convert.ToInt32(TextBoxID.Text),
                EmployeeId = Convert.ToInt32(DropdownEmployee.SelectedValue),
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
