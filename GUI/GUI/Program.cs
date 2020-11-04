using GUI.FORMS;
using GUI.FORMS.FORM_IN_BC;
using GUI.FORMS.FORM_IN_BG;
using GUI.FORMS.FORM_IN_HD;
using GUI.FORMS.FORM_MENU;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
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
            Application.Run(new FormLogin());
        }
    }
}
