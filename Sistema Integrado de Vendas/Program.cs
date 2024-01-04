using Sistema_Integrado_de_Vendas.Telas;
using System;
using System.Windows.Forms;

namespace Sistema_Integrado_de_Vendas
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
