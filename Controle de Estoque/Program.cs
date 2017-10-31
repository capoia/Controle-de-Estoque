using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_de_Estoque
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frm_login logar = new frm_login();
            if (logar.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new frm_inicial());

            }

        }
    }
}
