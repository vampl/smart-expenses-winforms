using System;
using System.Configuration;
using System.Globalization;
using System.Windows.Forms;
using SmartExpense.Database;
using SmartExpense.Models;

namespace SmartExpense.Pages
{
    public partial class MainPage : UserControl
    {
        private DatabaseController _databaseController;
            
        public MainPage()
        {
            InitializeComponent();
            _databaseController = new DatabaseController();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            LblBalanceValue.Text = _databaseController.GetBalanceSum(User.Id).ToString(CultureInfo.CurrentCulture);
        }
    }
}