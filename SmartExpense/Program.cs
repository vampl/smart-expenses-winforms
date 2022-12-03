using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartExpense.Database;
using SmartExpense.Pages;

namespace SmartExpense
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            // Register database controller service to use.
            var databaseController = new DatabaseController();
            Locator.Register<DatabaseController>(databaseController);
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SmartExpenseMain());
        }
    }
}