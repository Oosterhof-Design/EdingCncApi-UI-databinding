using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EdingCncDatabinding
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
            //Application.Run(new Form1());
            using (Form1 Example = new Form1())
            {
                Example.ShowDialog();
            }


                OosterhofDesign.G_GetCncServer.DisConnectServer();
        }
    }
}
