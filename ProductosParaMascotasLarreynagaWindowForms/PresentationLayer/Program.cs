using PresentationLayer.FormsInventoryManager;
using System;
using System.Windows.Forms;
namespace PresentationLayer
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
            //Application.Run(new FormInventoryManagerAddProduct());
        }
    }
}
