using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SmartExpense.Database;
using SmartExpense.Models;

namespace SmartExpense.Pages
{
    public partial class AccountPage : UserControl
    {
        public AccountPage()
        {
            InitializeComponent();
        }

        // load from list to data grid view.
        private void LoadData(List<Account> accountsList)
        {
            DgvAccountsTable.Rows.Clear();
            
            foreach (var account in accountsList)
            {
                var newRow = new DataGridViewRow();  
  
                newRow.CreateCells(DgvAccountsTable);
                
                newRow.Cells[0].Value = account.Id;  
                newRow.Cells[1].Value = account.OwnerId;  
                newRow.Cells[2].Value = account.Title;  
                newRow.Cells[3].Value = account.Type;  
                newRow.Cells[4].Value = account.Description;  
                newRow.Cells[5].Value = account.Amount;
                
                DgvAccountsTable.Rows.Add(newRow);  
            }
        }
        
        // add new row with user data.
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var accountDataForm = new AccountDataFormerDialog();
            var result = accountDataForm.ShowDialog(this);
 
            if (result == DialogResult.Cancel)
                return;

            try
            {
                // get general connected database service.
                var db = Locator.GetService<DatabaseController>();
                db.InsertAccountData(accountDataForm.Account);
                var accounts = db.ReadAccountData();
                LoadData(accounts);
            }
            catch (Exception exception)
            {
                MessageBox.Show(@"Adding account error - " + exception.Message, @"Error", MessageBoxButtons.OK);
            }
        }
        
        // load account table from database.
        private void AccountPage_Load(object sender, EventArgs e)
        {
            try
            {
                // get general connected database service.
                var db = Locator.GetService<DatabaseController>();
                db.ReadAccountData();
                var accounts = db.ReadAccountData();
                LoadData(accounts);
            } catch (Exception exception)
            {
                MessageBox.Show(@"Loading Account page error - " + exception.Message, @"Error", MessageBoxButtons.OK);
            }
        }
        
        // delete chosen row from data grid view. 
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (DgvAccountsTable.CurrentRow == null)
                    return;

                var account = new Account
                {
                    Id = uint.Parse(DgvAccountsTable.CurrentRow.Cells[0].Value.ToString()),
                    OwnerId = uint.Parse(DgvAccountsTable.CurrentRow.Cells[1].Value.ToString()),
                    Title = DgvAccountsTable.CurrentRow.Cells[2].Value.ToString(),
                    Type = DgvAccountsTable.CurrentRow.Cells[3].Value.ToString(),
                    Description = DgvAccountsTable.CurrentRow.Cells[4].Value.ToString(),
                    Amount = decimal.Parse(DgvAccountsTable.CurrentRow.Cells[5].Value.ToString())
                };

                // get general connected database service.
                var db = Locator.GetService<DatabaseController>();
                db.DeleteAccountData(account);
                var accounts = db.ReadAccountData();
                LoadData(accounts);
            } 
            catch (Exception exception)
            {
                MessageBox.Show(@"Deletion account error - " + exception.Message, @"Error", MessageBoxButtons.OK);
            }
        }
    }
}