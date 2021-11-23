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
    public partial class FormMenu : Form
    {
        private List<(Button, Image, Image)> _buttons = new List<(Button, Image, Image)>();
        private Panel _mainContainer;
        private Form _activeForm = null;

        public FormMenu(Panel mainContainer)
        {
            InitializeComponent();
            _buttons.Add((ButtonInventoryManager, InventoryManager.box_icon_invertoy_manager, InventoryManager.box_icon_invertoy_manager_gray));
            _buttons.Add((ButtonPointOfSale, InventoryManager.point_of_sale_white, InventoryManager.point_of_sale_gray));
            _buttons.Add((ButtonSuppliers, InventoryManager.fluent_person_support_white, InventoryManager.fluent_person_support_gray));
            _buttons.Add((ButtonClients, InventoryManager.people_community_white, InventoryManager.people_community_gray));
            _buttons.Add((ButtonEmployees, InventoryManager.employee_group_white, InventoryManager.employee_group_gray));
            _buttons.Add((ButtonSales, InventoryManager.monetization_green, InventoryManager.monetization_gray));
            _mainContainer = mainContainer;
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            _buttons.FirstOrDefault().Item1.PerformClick();
        }

        private void ButtonInventoryManager_Click(object sender, EventArgs e)
        {
            _openFormInPanel(new FormInventoryManagement(), _mainContainer);
            _paintSelectedButton((Button)sender);
        }

        private void ButtonPointOfSale_Click(object sender, EventArgs e)
        {
            _paintSelectedButton((Button)sender);
        }

        private void ButtonSuppliers_Click(object sender, EventArgs e)
        {
            _paintSelectedButton((Button)sender);
        }

        private void ButtonClients_Click(object sender, EventArgs e)
        {
            _paintSelectedButton((Button)sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _paintSelectedButton((Button)sender);
        }

        private void ButtonSales_Click(object sender, EventArgs e)
        {
            _paintSelectedButton((Button)sender);
        }

        private void _paintSelectedButton(Button sender)
        {
            _buttons.ForEach(b =>
            {
                if (!b.Item1.Equals(sender))
                {
                    b.Item1.BackColor = Color.FromArgb(22, 31, 25);
                    b.Item1.Image = b.Item3;
                    b.Item1.ForeColor = Color.FromArgb(208, 205, 225);
                }
                else
                {
                    sender.BackColor = Color.FromArgb(90, 164, 50);
                    sender.Image = b.Item2;
                    sender.ForeColor = Color.White;
                }
            });
        }

        private void _openFormInPanel(Form form, Panel panel)
        {
            if (_activeForm != null)
            {
                _activeForm.Close();
            }
            //activarBoton(sender);
            _activeForm = form;
            _activeForm.TopLevel = false;
            _activeForm.Dock = DockStyle.Fill;
            panel.Controls.Add(_activeForm);
            panel.Tag = _activeForm;
            _activeForm.BringToFront();
            _activeForm.Show();
        }
    }
}
