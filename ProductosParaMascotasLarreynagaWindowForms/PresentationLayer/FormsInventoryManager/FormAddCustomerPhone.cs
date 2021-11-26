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
    public partial class FormAddCustomerPhone : Form
    {
        public BusinessCustomerPhone _dbPhone = new BusinessCustomerPhone();
        public BusinessCustomer _dbCustomer = new BusinessCustomer();
        private int CustomerId;

        public FormAddCustomerPhone(int CustomerId)
        {
            InitializeComponent();
            this.CustomerId = CustomerId;
        }

        private void FormAddCustomerPhone_Load(object sender, EventArgs e)
        {
            TextBoxID.Text = "Auto-Generado";
            DropdownEmployee.DataSource = _dbCustomer.Get();
            DropdownEmployee.ValueMember = "ID Cliente";
            DropdownEmployee.DisplayMember = "Nombre Completo";
            DropdownEmployee.SelectedIndex = CustomerId - 1;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            var phone = new EntityCustomerPhone()
            {
                CustomerId = Convert.ToInt32(DropdownEmployee.SelectedValue),
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
