using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SmartExpense.Database;
using SmartExpense.Models;

namespace SmartExpense.Pages
{
    public partial class AccountPage : UserControl
    {
        private readonly DatabaseController _databaseController;

        public AccountPage()
        {
            InitializeComponent();
            _databaseController = new DatabaseController();
        }

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
        
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var accountDataForm = new AccountDataFormerDialog();
            var result = accountDataForm.ShowDialog(this);
 
            if (result == DialogResult.Cancel)
                return;

            try
            {
                _databaseController.InsertAccountData(accountDataForm.Account);
                var accounts = _databaseController.ReadAccountData();
                LoadData(accounts);
            }
            catch (Exception exception)
            {
                MessageBox.Show($@"Error: {exception}", @"Error!", MessageBoxButtons.OK);
            }
        }
        
        private void AccountPage_Load(object sender, EventArgs e)
        {
            try
            {
                _databaseController.ReadAccountData();
                var accounts = _databaseController.ReadAccountData();
                LoadData(accounts);
            } catch (Exception exception)
            {
                MessageBox.Show($@"Error: {exception}", @"Error!", MessageBoxButtons.OK);
            }
        }

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

                _databaseController.DeleteAccountData(account);
                var accounts = _databaseController.ReadAccountData();
                LoadData(accounts);
            } catch (Exception exception)
            {
                MessageBox.Show($@"Error: {exception}", @"Error!", MessageBoxButtons.OK);
            }
        }
    }
}