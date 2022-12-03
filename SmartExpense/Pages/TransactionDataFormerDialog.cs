using System;
using System.Windows.Forms;
using SmartExpense.Database;
using SmartExpense.Models;

namespace SmartExpense.Pages
{
    public partial class TransactionDataFormerDialog : Form
    {
        public TransactionDataFormerDialog()
        {
            InitializeComponent();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // get general connected database service.
                var db = Locator.GetService<DatabaseController>();
                
                var transaction = new Transaction
                {
                    Id = uint.Parse(TbId.Text),
                    OwnerId = uint.Parse(TbOwnerId.Text),
                    Amount = decimal.Parse(TbAmount.Text),
                    Type = CbType.Text,
                    Description = TbDesctiption.Text,
                    Date = DtpTransactionDay.Value,
                    AccountTitle = CbAccounts.Text
                };
                
                db.UpdateTransactionData(transaction);
            }
            catch (Exception exception)
            {
                MessageBox.Show(@"Adding account error - " + exception.Message, @"Error", MessageBoxButtons.OK);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // get general connected database service.
                var db = Locator.GetService<DatabaseController>();
                
                var transaction = new Transaction
                {
                    OwnerId = User.Id,
                    Amount = decimal.Parse(TbAmount.Text),
                    Type = CbType.Text,
                    Description = TbDesctiption.Text,
                    Date = DtpTransactionDay.Value,
                    AccountTitle = CbAccounts.Text
                };
                
                db.DeleteTransactionData(transaction);
            }
            catch (Exception exception)
            {
                MessageBox.Show(@"Adding account error - " + exception.Message, @"Error", MessageBoxButtons.OK);
            }
        }
        
    }
}