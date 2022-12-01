using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SmartExpense.Database;
using SmartExpense.Models;

namespace SmartExpense.Pages
{
    public partial class AccountPage : UserControl
    {
        // ToDo: refactor
        private DatabaseController _databaseController;
        private List<Account> _accounts;
        public AccountPage()
        {
            InitializeComponent();
            _databaseController = new DatabaseController();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            
        }
        
        private void GetData()  
        {  
            try
            {
                _accounts = new List<Account>();
                _databaseController.Open();  
                var query = "SELECT * FROM Account";
                
                var row = _databaseController.ExecuteReader(query);  
                
                if (row.HasRows)  
                {  
                    while (row.Read())
                    {
                        var account = new Account
                        {
                            OwnerId = uint.Parse(row["OwnerId"].ToString()),
                            Id = uint.Parse(row["Id"].ToString()), 
                            Title = row["Title"].ToString(),
                            Type = row["Type"].ToString(),
                            Description = row["Description"].ToString(),
                            Amount = decimal.Parse(row["Amount"].ToString())
                        };
                        
                        _accounts.Add(account);
                    }
                    
                    DgvAccountsTable.Rows.Clear();
                    foreach (var account in _accounts)
                    {
                        var newRow = new DataGridViewRow();  
  
                        newRow.CreateCells(DgvAccountsTable);  
                        newRow.Cells[0].Value = account.Title;  
                        newRow.Cells[1].Value = account.Type;  
                        newRow.Cells[2].Value = account.Description;  
                        newRow.Cells[3].Value = account.Amount;
                        DgvAccountsTable.Rows.Add(newRow);  
                    }
                }  
                else  
                {  
                    MessageBox.Show("Data not found");  
                }  
  
                _databaseController.Close();
            }  
            catch (Exception err)  
            {  
                MessageBox.Show(err.ToString());  
            }  
  
        }

        private void AccountPage_Load(object sender, EventArgs e)
        {
            GetData();
        }
    }
}