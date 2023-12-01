using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCC_Padaria.view;

namespace TCC_Padaria
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
             //Application.Run(new frmLogin());
            //Application.Run(new frmCadastroPessoa());
            Application.Run(new frmCadastroPessoa());
            //Application.Run(new frmJanelaPrincipal());
        }
    }
}
