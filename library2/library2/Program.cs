using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library2
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

            DataGridViews.library_db.InitiateComponents();
            //Application.Run(new Form6());
            SettingsClass.InitializeComponents();
            SettingsClass.getData();
            Application.Run(new Form2());
            //Application.Run(new Form1("Читатель"));
            //Application.Run(new Form1("Администратор"));
        }
    }
}
