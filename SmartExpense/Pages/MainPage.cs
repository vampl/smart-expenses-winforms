using System;
using System.Windows.Forms;
using SmartExpense.Database;

namespace SmartExpense.Pages
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
        }

        // Load general information for page.
        private void MainPage_Load(object sender, EventArgs e)
        {
            try
            {
                // get general connected database service.
                var db = Locator.GetService<DatabaseController>();

                if (db == null)
                    return;

                // load systematized information on accounts and transactions.
                LblBalanceValue.Text = db.GetBalanceSum().ToString();
                LblExpenceValue.Text = db.GetExpenseSum().ToString();
                LblIncomeValue.Text = db.GetIncomeSum().ToString();
            }
            catch (Exception exception)
            {
                MessageBox.Show(@"Loading Main page -" + exception.Message, @"Error", MessageBoxButtons.OK);
            }
        }
    }
}