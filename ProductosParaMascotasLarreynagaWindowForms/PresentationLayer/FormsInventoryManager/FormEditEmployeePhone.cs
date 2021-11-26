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
    public partial class FormEditEmployeePhone : Form
    {
        public BusinessEmployeePhone _dbPhone = new BusinessEmployeePhone();
        public BusinessEmployee _dbEmployee = new BusinessEmployee();
        private EntityEmployeePhone employeePhone;

        public FormEditEmployeePhone(EntityEmployeePhone employeePhone)
        {
            InitializeComponent();
            this.employeePhone = employeePhone;
        }

        private void FormEditEmployeePhone_Load(object sender, EventArgs e)
        {
            TextBoxID.Text = employeePhone.PhoneId.ToString();
            DropdownEmployee.DataSource = _dbEmployee.Get();
            DropdownEmployee.ValueMember = "ID";
            DropdownEmployee.DisplayMember = "Nombre Completo";
            DropdownEmployee.SelectedIndex = employeePhone.EmployeeId - 1;
            TextBoxPhone.Text = employeePhone.Number;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            var phone = new EntityEmployeePhone()
            {
                PhoneId = Convert.ToInt32(TextBoxID.Text),
                EmployeeId = Convert.ToInt32(DropdownEmployee.SelectedValue),
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
            var phone = new EntityEmployeePhone()
            {
                PhoneId = Convert.ToInt32(TextBoxID.Text),
                EmployeeId = Convert.ToInt32(DropdownEmployee.SelectedValue),
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
