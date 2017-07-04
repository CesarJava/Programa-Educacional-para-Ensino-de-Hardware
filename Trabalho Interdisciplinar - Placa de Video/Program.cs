using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Trabalho_Interdisciplinar___Placa_de_Video
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
