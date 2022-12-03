using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SmartExpense.Models;

namespace SmartExpense.Database
{
    public class DatabaseController
    {
        // established connection.
        private readonly MySqlConnection _connection;

        // constant connection data.
        private const string ConnectionString =
            "server=localhost;port=3306;user=root;password=root_password;database=SmartExpenseDatabase";

        public DatabaseController()
        {
            _connection = new MySqlConnection();
            _connection.ConnectionString = ConnectionString;
        }

        // open established connection.
        private void Open()
        {
            try
            {
                _connection.Open();
            }
            catch (Exception exception)
            {
                MessageBox.Show(@"Connection Error - " + exception.Message, @"Error", MessageBoxButtons.OK);
            }
        }

        // close established connection.
        private void Close()
        {
            _connection.Close();
            _connection.Dispose();
        }

        /* Account table region. */
        // Insertion.
        public void InsertAccountData(Account account)
        {
            Open();

            try
            {
                // create command and bind values to insert.
                var cmd = new MySqlCommand();
                cmd.Connection = _connection;
                cmd.CommandText =
                    "Insert Into Account(OwnerId, Title, Type, Description, Amount) Values(@OwnerId, @Title, @Type, @Description, @Amount)";

                cmd.Parameters.AddWithValue("@OwnerId", account.OwnerId);
                cmd.Parameters.AddWithValue("@Title", account.Title);
                cmd.Parameters.AddWithValue("@Type", account.Type);
                cmd.Parameters.AddWithValue("@Description", account.Description);
                cmd.Parameters.AddWithValue("@Amount", account.Amount);
                
                cmd.ExecuteNonQuery();
            }
            catch(Exception exception)
            {
                MessageBox.Show(@"Insertion error - " + exception.Message, @"Error", MessageBoxButtons.OK);
            }

            Close();
        }

        // Deletion.
        public void DeleteAccountData(Account account)
        {
            Open();

            try
            {
                // create command and bind specified id.
                var cmd = new MySqlCommand();
                cmd.Connection = _connection;
                cmd.CommandText =
                    "Delete from Account where Id = @Id";

                cmd.Parameters.AddWithValue("@Id", account.Id);
                cmd.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                MessageBox.Show(@"Deletion error - " + exception.Message, @"Error", MessageBoxButtons.OK);
            }

            Close();
        }
        
        // Reading.
        public List<Account> ReadAccountData()
        {
            Open();

            // result data
            var accountsList = new List<Account>();
            
            try
            {
                // create command for reader.
                var cmd = new MySqlCommand();
                cmd.Connection = _connection;
                cmd.CommandText = $"Select * from Account where OwnerId = {User.Id}";

                var reader = cmd.ExecuteReader();

                // empty reader.
                if (!reader.HasRows)
                {
                    Close();
                    return new List<Account>();
                }

                // transfer from Reader to list.
                while (reader.Read())
                {
                    var account = new Account
                    {
                        OwnerId = uint.Parse(reader["OwnerId"].ToString()),
                        Id = uint.Parse(reader["Id"].ToString()),
                        Title = reader["Title"].ToString(),
                        Type = reader["Type"].ToString(),
                        Description = reader["Description"].ToString(),
                        Amount = decimal.Parse(reader["Amount"].ToString())
                    };

                    accountsList.Add(account);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(@"Reading error - " + exception.Message, @"Error", MessageBoxButtons.OK);
            }

            Close();
            
            return accountsList;
        }
        /* end Account table region */
        
        /* Transaction table region. */
        // Insertion.
        public void InsertTransactionData(Transaction transaction)
        {
            Open();

            try
            {
                // create command and bind values to insert.
                var cmd = new MySqlCommand();
                cmd.Connection = _connection;
                cmd.CommandText =
                    "Insert Into Transaction(OwnerId, Amount, Type, Description, Date, AccountTitle) " + 
                    "Values(@OwnerId, @Amount, @Type, @Description, @Date, @AccountTitle)";

                cmd.Parameters.AddWithValue("@OwnerId", transaction.OwnerId);
                cmd.Parameters.AddWithValue("@Amount", transaction.Amount);
                cmd.Parameters.AddWithValue("@Type", transaction.Type);
                cmd.Parameters.AddWithValue("@Description", transaction.Description);
                cmd.Parameters.AddWithValue("@Date", transaction.Date);
                cmd.Parameters.AddWithValue("@AccountTitle", transaction.AccountTitle);
                
                cmd.ExecuteNonQuery();
            }
            catch(Exception exception)
            {
                MessageBox.Show(@"Insertion error - " + exception.Message, @"Error", MessageBoxButtons.OK);
            }

            Close();
        }

        // Deletion.
        public void DeleteTransactionData(Transaction transaction)
        {
            Open();

            try
            {
                // create command and bind specified id.
                var cmd = new MySqlCommand();
                cmd.Connection = _connection;
                cmd.CommandText =
                    "Delete from Transaction where Id = @Id";

                cmd.Parameters.AddWithValue("@Id", transaction.Id);
                cmd.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                MessageBox.Show(@"Deletion error - " + exception.Message, @"Error", MessageBoxButtons.OK);
            }

            Close();
        }
        
        // Updating.
        public void UpdateTransactionData(Transaction transaction)
        {
            Open();

            try
            {
                // create command and bind specified id.
                var cmd = new MySqlCommand();
                cmd.Connection = _connection;
                cmd.CommandText =
                    "Update Transaction " +
                    "Set Amount = @Amount, Type = @Type, Description = @Description, Date = @Date, AccountTitle = @AccountTitle " +
                    "where Id = @Id";

                cmd.Parameters.AddWithValue("@Amount", transaction.Amount);
                cmd.Parameters.AddWithValue("@Type", transaction.Type);
                cmd.Parameters.AddWithValue("@Description", transaction.Description);
                cmd.Parameters.AddWithValue("@Date", transaction.Date);
                cmd.Parameters.AddWithValue("@AccountTitle", transaction.AccountTitle);
                cmd.Parameters.AddWithValue("@Id", transaction.Id);
                cmd.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                MessageBox.Show(@"Deletion error - " + exception.Message, @"Error", MessageBoxButtons.OK);
            }

            Close();
        }
        
        // Reading.
        public List<Transaction> ReadTransactionData()
        {
            Open();

            // result data
            var transactionsList = new List<Transaction>();
            
            try
            {
                // create command for reader.
                var cmd = new MySqlCommand();
                cmd.Connection = _connection;
                cmd.CommandText = $"Select * from Transaction where OwnerId = {User.Id}";

                var reader = cmd.ExecuteReader();

                // empty reader.
                if (!reader.HasRows)
                {
                    Close();
                    return new List<Transaction>();
                }

                // transfer from Reader to list.
                while (reader.Read())
                {
                    var transaction = new Transaction
                    {
                        Id = uint.Parse(reader["Id"].ToString()),
                        OwnerId = uint.Parse(reader["OwnerId"].ToString()),
                        Amount = decimal.Parse(reader["Amount"].ToString()),
                        Type = reader["Type"].ToString(),
                        Description = reader["Description"].ToString(),
                        Date = DateTime.Parse(reader["Date"].ToString()),
                        AccountTitle = reader["AccountTitle"].ToString()
                    };

                    transactionsList.Add(transaction);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(@"Reading error - " + exception.Message, @"Error", MessageBoxButtons.OK);
            }

            Close();
            
            return transactionsList;
        }
        
        // get current account title.
        public List<string> GetAccountsTitle()
        {
            Open();

            // result data
            var accountsTitleList = new List<string>();
            
            try
            {
                // create command for reader.
                var cmd = new MySqlCommand();
                cmd.Connection = _connection;
                cmd.CommandText = $"Select Title from Account where OwnerId = {User.Id}";

                var reader = cmd.ExecuteReader();

                // empty reader.
                if (!reader.HasRows)
                {
                    Close();
                    return new List<string>();
                }

                // transfer from Reader to list.
                while (reader.Read())
                {
                    var title = reader["Title"].ToString();
                    accountsTitleList.Add(title);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(@"Reading error - " + exception.Message, @"Error", MessageBoxButtons.OK);
            }

            Close();
            
            return accountsTitleList;
        }
        /* end Transaction table region */
        
        /* General information for the Main page */
        // Get calculated all account.
        public decimal GetBalanceSum()
        {
            Open();

            decimal balance = 0;

            try
            {
                // get calculated all accounts balance.
                var cmd = new MySqlCommand();

                cmd.Connection = _connection;
                cmd.CommandText = $"Select Sum(Amount) from Account where OwnerId = {User.Id}";

                var result = cmd.ExecuteScalar();

                // check if have data
                if (result == DBNull.Value)
                {
                    Close();
                    return 0;
                }

                balance = decimal.Parse(result.ToString());
            }
            catch (Exception exception)
            {
                MessageBox.Show(@"Getting sum calculation error - " + exception.Message, @"Error", MessageBoxButtons.OK);
            }

            Close();
            
            return balance;
        }

        // Get calculated all expense transaction amount sum.
        public decimal GetExpenseSum()
        {
            Open();

            decimal expenseSum = 0;

            try
            {
                // get calculated all expenses sum.
                var cmd = new MySqlCommand();

                cmd.Connection = _connection;
                cmd.CommandText = $"Select Sum(Amount) from Transaction where (OwnerId = {User.Id}) and (Type = 'Expense')";

                var result = cmd.ExecuteScalar();

                // check if have data
                if (result == DBNull.Value)
                {
                    Close();
                    return 0;
                }

                expenseSum = decimal.Parse(result.ToString());
            }
            catch (Exception exception)
            {
                MessageBox.Show(@"Getting sum calculation error - " + exception.Message, @"Error", MessageBoxButtons.OK);
            }

            Close();
            
            return expenseSum;
        }
        
        // Get calculated all income transaction amount sum.
        public decimal GetIncomeSum()
        {
            Open();

            decimal incomeSum = 0;

            try
            {
                // get calculated all expenses sum.
                var cmd = new MySqlCommand();

                cmd.Connection = _connection;
                cmd.CommandText = $"Select Sum(Amount) from Transaction where (OwnerId = {User.Id}) and (Type = 'Income')";

                var result = cmd.ExecuteScalar();

                // check if have data
                if (result == DBNull.Value)
                {
                    Close();
                    return 0;
                }

                incomeSum = decimal.Parse(result.ToString());
            }
            catch (Exception exception)
            {
                MessageBox.Show(@"Getting sum calculation error - " + exception.Message, @"Error", MessageBoxButtons.OK);
            }

            Close();
            
            return incomeSum;
        }
        /* end General information for the Main page region */
    }
}