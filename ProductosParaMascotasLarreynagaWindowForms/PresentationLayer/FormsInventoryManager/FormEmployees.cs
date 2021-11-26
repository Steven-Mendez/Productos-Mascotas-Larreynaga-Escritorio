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
    public partial class FormEmployees : Form
    {
        private BusinessEmployee _dbEmployee = new BusinessEmployee();

        public FormEmployees()
        {
            InitializeComponent();
        }

        private void FormEmployees_Load(object sender, EventArgs e)
        {
            DG.DataSource = _dbEmployee.Get();
        }

        private void DG_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DG.SelectedRows.Count != 1)
            {
                MessageBox.Show("Seleccione una fila antes de modificar.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewCellCollection cells = DG.CurrentRow.Cells;
            var dt = _dbEmployee.SelectEngine(Convert.ToString(cells["ID"].Value));
            var employee = new EntityEmployee()
            {
                EmployeeId = Convert.ToInt32(cells["ID"].Value),
                EmployeePositionId = Convert.ToInt32(dt.Rows[0][1]),
                BranchOfficeId = Convert.ToInt32(dt.Rows[0][2]),
                MunicipalityId = Convert.ToInt32(dt.Rows[0][3]),
                FirstName = Convert.ToString(dt.Rows[0][4]),
                SecondName = Convert.ToString(dt.Rows[0][5]),
                FirstSurname = Convert.ToString(dt.Rows[0][6]),
                SecondSurname = Convert.ToString(dt.Rows[0][7]),
                Identification = Convert.ToString(dt.Rows[0][8]),
                Address = Convert.ToString(dt.Rows[0][9]),
                StreetNumber = Convert.ToInt32(dt.Rows[0][10]),
                StreetName = Convert.ToString(dt.Rows[0][11])
            };
            var show_employe = new FormEditEmployee(employee);
            show_employe.ShowDialog();
            DG.DataSource = _dbEmployee.Get(TextBoxSearch.Text);
        }

        private void TextBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DG.DataSource = _dbEmployee.Get(TextBoxSearch.Text);
            }
        }

        private void ImageButtonAdd_Click(object sender, EventArgs e)
        {
            var new_employee = new FormAddEmployee();
            new_employee.ShowDialog();
            DG.DataSource = _dbEmployee.Get(TextBoxSearch.Text);
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (DG.SelectedRows.Count != 1)
            {
                MessageBox.Show("Seleccione una fila antes de modificar.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewCellCollection cells = DG.CurrentRow.Cells;
            var dt = _dbEmployee.SelectEngine(Convert.ToString(cells["ID"].Value));
            var employee = new EntityEmployee()
            {
                EmployeeId = Convert.ToInt32(cells["ID"].Value),
                EmployeePositionId = Convert.ToInt32(dt.Rows[0][1]),
                BranchOfficeId = Convert.ToInt32(dt.Rows[0][2]),
                MunicipalityId = Convert.ToInt32(dt.Rows[0][3]),
                FirstName = Convert.ToString(dt.Rows[0][4]),
                SecondName = Convert.ToString(dt.Rows[0][5]),
                FirstSurname = Convert.ToString(dt.Rows[0][6]),
                SecondSurname = Convert.ToString(dt.Rows[0][7]),
                Identification = Convert.ToString(dt.Rows[0][8]),
                Address = Convert.ToString(dt.Rows[0][9]),
                StreetNumber = Convert.ToInt32(dt.Rows[0][10]),
                StreetName = Convert.ToString(dt.Rows[0][11])
            };
            var show_employe = new FormEditEmployee(employee);
            show_employe.ShowDialog();
            DG.DataSource = _dbEmployee.Get(TextBoxSearch.Text);
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            if (DG.SelectedRows.Count != 1)
            {
                MessageBox.Show("Seleccione una fila antes de eliminar.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewCellCollection cells = DG.CurrentRow.Cells;
            var dt = _dbEmployee.SelectEngine(Convert.ToString(cells["ID"].Value));
            var employee = new EntityEmployee()
            {
                EmployeeId = Convert.ToInt32(cells["ID"].Value),
                EmployeePositionId = Convert.ToInt32(dt.Rows[0][1]),
                BranchOfficeId = Convert.ToInt32(dt.Rows[0][2]),
                MunicipalityId = Convert.ToInt32(dt.Rows[0][3]),
                FirstName = Convert.ToString(dt.Rows[0][4]),
                SecondName = Convert.ToString(dt.Rows[0][5]),
                FirstSurname = Convert.ToString(dt.Rows[0][6]),
                SecondSurname = Convert.ToString(dt.Rows[0][7]),
                Identification = Convert.ToString(dt.Rows[0][8]),
                Address = Convert.ToString(dt.Rows[0][9]),
                StreetNumber = Convert.ToInt32(dt.Rows[0][10]),
                StreetName = Convert.ToString(dt.Rows[0][11])
            };
            if (_dbEmployee.Delete(employee) >= 1)
            {
                DG.DataSource = _dbEmployee.Get(TextBoxSearch.Text);
            }
            else
            {
                MessageBox.Show("Algo Salio Mal", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
