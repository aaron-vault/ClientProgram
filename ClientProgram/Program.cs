using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientProgram.Presenters;
using ClientProgram.Views;
using ClientProgramLib.Data;
using DevExpress.XtraEditors;

namespace ClientProgram
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var mainForm = new MainForm();
            var mainPresenter = new MainPresenter(mainForm);

            Application.Run(mainForm);
        }
    }
}
