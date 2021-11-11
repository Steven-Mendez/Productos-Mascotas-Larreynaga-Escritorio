using PresentationLayer.FormsInventoryManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class FormMain : Form
    {
        private Form _activeForm = null;

        public FormMain()
        {
            InitializeComponent();
            _openFormInPanel(new FormMenu(PanelContainer), PanelButtons);
        }

        private void ImageButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ImageButtonMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
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
