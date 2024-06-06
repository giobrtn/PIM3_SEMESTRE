using PIM3_SEMESTRE.cliente;
using PIM3_SEMESTRE.fornecedor;
using PIM3_SEMESTRE.notificações;
using PIM3_SEMESTRE.produção;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM3_SEMESTRE
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

            Application.Run(new tela_notificações());

        }
    }
}
