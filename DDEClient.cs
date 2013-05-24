using System;
using System.Windows.Forms;

namespace CsDDE_Simple_
{
    static class DDEClient
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DDEClientFrm());
        }
    }
}
