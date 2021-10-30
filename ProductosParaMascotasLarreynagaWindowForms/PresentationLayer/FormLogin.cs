using System;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class FormLogin : Form
    {
        private bool _isPasswordActivated = true;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void ImageButtonShowPassword_Click(object sender, EventArgs e)
        {
            _isPasswordActivated = !_isPasswordActivated;
            TextBoxPassword.PasswordChar = _isPasswordActivated ? '●' : '\0';
            ImageButtonShowPassword.Image = _isPasswordActivated ? Assets.eye : Assets.eye_closed;
            ToolTip.SetToolTip(ImageButtonShowPassword, _isPasswordActivated ? "Mostrar Contraseña" : "Ocultar Contraseña");
        }

        private void ImageButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ImageButtonMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}