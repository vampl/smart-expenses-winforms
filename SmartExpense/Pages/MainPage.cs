using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SmartExpense.Database;
using SmartExpense.Models;

namespace SmartExpense.Pages
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
        }

        // load transaction table
        private void LoadData(List<Transaction> transactionsList)
        {
            DgvTransactionTable.Rows.Clear();
            
            foreach (var transaction in transactionsList)
            {
                var newRow = new DataGridViewRow();  
  
                newRow.CreateCells(DgvTransactionTable);
                
                newRow.Cells[0].Value = transaction.Id;  
                newRow.Cells[1].Value = transaction.OwnerId;  
                newRow.Cells[2].Value = transaction.Amount;  
                newRow.Cells[3].Value = transaction.Type;  
                newRow.Cells[4].Value = transaction.Description;  
                newRow.Cells[5].Value = transaction.Date;
                newRow.Cells[6].Value = transaction.AccountTitle;
                
                DgvTransactionTable.Rows.Add(newRow);  
            }
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
                
                // get general connected database service.
                var transactions = db.ReadTransactionData();
                LoadData(transactions);
            }
            catch (Exception exception)
            {
                MessageBox.Show(@"Loading Main page - " + exception.Message, @"Error", MessageBoxButtons.OK);
            }
        }

        // load data for edit/delete to page from table.
        private void DgvTransactionTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // create dialog to where insert.
                var transactionDataForm = new TransactionDataFormerDialog();
                
                if (DgvTransactionTable.CurrentRow == null)
                    return;
                
                transactionDataForm.TbId.Text = DgvTransactionTable.CurrentRow.Cells[0].Value.ToString();
                transactionDataForm.TbOwnerId.Text = DgvTransactionTable.CurrentRow.Cells[1].Value.ToString();
                transactionDataForm.TbAmount.Text = DgvTransactionTable.CurrentRow.Cells[2].Value.ToString();
                transactionDataForm.CbType.Text = DgvTransactionTable.CurrentRow.Cells[3].Value.ToString();
                transactionDataForm.TbDesctiption.Text = DgvTransactionTable.CurrentRow.Cells[4].Value.ToString();
                transactionDataForm.DtpTransactionDay.Text = DgvTransactionTable.CurrentRow.Cells[5].Value.ToString();
                transactionDataForm.CbAccounts.Text = DgvTransactionTable.CurrentRow.Cells[6].Value.ToString();
                
                var result = transactionDataForm.ShowDialog(this);
 
                if (result == DialogResult.Cancel)
                    return;

                var transaction = new Transaction
                {
                    Id = uint.Parse(transactionDataForm.TbId.Text),
                    OwnerId = uint.Parse(transactionDataForm.TbOwnerId.Text),
                    Amount = decimal.Parse(transactionDataForm.TbAmount.Text),
                    Type = transactionDataForm.CbType.Text,
                    Description = transactionDataForm.TbDesctiption.Text,
                    Date = transactionDataForm.DtpTransactionDay.Value,
                    AccountTitle = transactionDataForm.CbAccounts.Text
                };
                    
                // get general connected database service.
                var db = Locator.GetService<DatabaseController>();
                
                if (transactionDataForm.RdbUpdate.Checked)
                    db.UpdateTransactionData(transaction);

                if (transactionDataForm.RdbDelete.Checked)
                    db.DeleteTransactionData(transaction);

                var transactions = db.ReadTransactionData();
                LoadData(transactions);
                // load systematized information on accounts and transactions.
                LblBalanceValue.Text = db.GetBalanceSum().ToString();
                LblExpenceValue.Text = db.GetExpenseSum().ToString();
                LblIncomeValue.Text = db.GetIncomeSum().ToString();
            }
            catch (Exception exception)
            {
                MessageBox.Show(@"Delete/Update error - " + exception.Message, @"Error", MessageBoxButtons.OK);
            }
        }
    }
}