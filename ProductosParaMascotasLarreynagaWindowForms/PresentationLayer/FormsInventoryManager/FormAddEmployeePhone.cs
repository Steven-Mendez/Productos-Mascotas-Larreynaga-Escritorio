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
    public partial class FormAddEmployeePhone : Form
    {
        public BusinessEmployeePhone _dbPhone = new BusinessEmployeePhone();
        public BusinessEmployee _dbEmployee = new BusinessEmployee();
        private int EmployeeId;
        public FormAddEmployeePhone(int EmployeeId)
        {
            InitializeComponent();
            this.EmployeeId = EmployeeId;
        }

        private void FormAddPhone_Load(object sender, EventArgs e)
        {
            TextBoxID.Text = "Auto-Generado";
            DropdownEmployee.DataSource = _dbEmployee.Get();
            DropdownEmployee.ValueMember = "ID";
            DropdownEmployee.DisplayMember = "Nombre Completo";
            DropdownEmployee.SelectedIndex = EmployeeId - 1;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            var phone = new EntityEmployeePhone()
            {
                EmployeeId = Convert.ToInt32(DropdownEmployee.SelectedValue),
                Number = TextBoxPhone.Text
            };
            if (_dbPhone.Add(phone) >= 1)
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
