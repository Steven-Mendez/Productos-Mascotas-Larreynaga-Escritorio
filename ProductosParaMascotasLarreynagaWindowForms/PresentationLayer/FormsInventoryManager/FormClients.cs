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
    public partial class FormClients : Form
    {
        private BusinessCustomer _dbCustomers = new BusinessCustomer();

        public FormClients()
        {
            InitializeComponent();
        }

        private void FormClients_Load(object sender, EventArgs e)
        {
            DG.DataSource = _dbCustomers.Get();
        }

        private void DG_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (DG.SelectedRows.Count != 1)
            //{
            //    MessageBox.Show("Seleccione una fila antes de modificar.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            //DataGridViewCellCollection cells = DG.CurrentRow.Cells;
            //var dt = _dbCustomers.SelectEngine(Convert.ToString(cells[0].Value));
            //var customer = new EntityCustomer()
            //{
            //    CustomerId = Convert.ToInt32(dt.Rows[0][0]),
            //    MunicipalityId = Convert.ToInt32(dt.Rows[0][1]),
            //    FirstName = Convert.ToString(dt.Rows[0][2]),
            //    SecondName = Convert.ToString(dt.Rows[0][3]),
            //    FirstSurname = Convert.ToString(dt.Rows[0][4]),
            //    SecondSurname = Convert.ToString(dt.Rows[0][5]),
            //    Identification = Convert.ToString(dt.Rows[0][6]),
            //    Address = Convert.ToString(dt.Rows[0][7]),
            //    StreetNumber = Convert.ToInt32(dt.Rows[0][8]),
            //    StreetName = Convert.ToString(dt.Rows[0][9])
            //};
            //var show_customer = new FormEditCustomer(customer);
            //show_customer.ShowDialog();
            //DG.DataSource = _dbCustomers.Get(TextBoxSearch.Text);
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (DG.SelectedRows.Count != 1)
            {
                MessageBox.Show("Seleccione una fila antes de modificar.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewCellCollection cells = DG.CurrentRow.Cells;
            var dt = _dbCustomers.SelectEngine(Convert.ToString(cells[0].Value));
            var customer = new EntityCustomer()
            {
                CustomerId = Convert.ToInt32(dt.Rows[0][0]),
                MunicipalityId = Convert.ToInt32(dt.Rows[0][1]),
                FirstName = Convert.ToString(dt.Rows[0][2]),
                SecondName = Convert.ToString(dt.Rows[0][3]),
                FirstSurname = Convert.ToString(dt.Rows[0][4]),
                SecondSurname = Convert.ToString(dt.Rows[0][5]),
                Identification = Convert.ToString(dt.Rows[0][6]),
                Address = Convert.ToString(dt.Rows[0][7]),
                StreetNumber = Convert.ToInt32(dt.Rows[0][8]),
                StreetName = Convert.ToString(dt.Rows[0][9])
            };
            var show_customer = new FormEditCustomer(customer);
            show_customer.ShowDialog();
            DG.DataSource = _dbCustomers.Get(TextBoxSearch.Text);
        }

        private void DG_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DG.SelectedRows.Count != 1)
            {
                MessageBox.Show("Seleccione una fila antes de modificar.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewCellCollection cells = DG.CurrentRow.Cells;
            var dt = _dbCustomers.SelectEngine(Convert.ToString(cells[0].Value));
            var customer = new EntityCustomer()
            {
                CustomerId = Convert.ToInt32(dt.Rows[0][0]),
                MunicipalityId = Convert.ToInt32(dt.Rows[0][1]),
                FirstName = Convert.ToString(dt.Rows[0][2]),
                SecondName = Convert.ToString(dt.Rows[0][3]),
                FirstSurname = Convert.ToString(dt.Rows[0][4]),
                SecondSurname = Convert.ToString(dt.Rows[0][5]),
                Identification = Convert.ToString(dt.Rows[0][6]),
                Address = Convert.ToString(dt.Rows[0][7]),
                StreetNumber = Convert.ToInt32(dt.Rows[0][8]),
                StreetName = Convert.ToString(dt.Rows[0][9])
            };
            var show_customer = new FormEditCustomer(customer);
            show_customer.ShowDialog();
            DG.DataSource = _dbCustomers.Get(TextBoxSearch.Text);
        }

        private void ImageButtonAdd_Click(object sender, EventArgs e)
        {
            var add_customer = new FormAddCustomer();
            add_customer.ShowDialog();
            DG.DataSource = _dbCustomers.Get(TextBoxSearch.Text);
        }

        private void TextBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DG.DataSource = _dbCustomers.Get(TextBoxSearch.Text);
            }
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            if (DG.SelectedRows.Count != 1)
            {
                MessageBox.Show("Seleccione una fila antes de eliminar.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewCellCollection cells = DG.CurrentRow.Cells;
            var employee = new EntityCustomer()
            {
                CustomerId = Convert.ToInt32(cells[0].Value)
            };
            if (_dbCustomers.Delete(employee) >= 1)
            {
                DG.DataSource = _dbCustomers.Get(TextBoxSearch.Text);
            }
            else
            {
                MessageBox.Show("Algo Salio Mal", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
