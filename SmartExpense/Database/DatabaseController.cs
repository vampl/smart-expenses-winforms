using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SmartExpense.Models;

namespace SmartExpense.Database
{
    public class DatabaseController
    {
        private MySqlConnection _connection;

        const string connectionString =
            "server=localhost;port=3306;user=root;password=root_password;database=SmartExpenseDatabase";

        public DatabaseController()
        {
            _connection = new MySqlConnection();
            _connection.ConnectionString = connectionString;
        }

        private bool Open()
        {
            try
            {
                _connection.Open();
                return true;
            }
            catch (Exception er)
            {
                MessageBox.Show(@"Connection Error ! " + er.Message, @"Information");
            }

            return false;
        }

        private void Close()
        {
            _connection.Close();
            _connection.Dispose();
        }

        public void InsertAccountData(Account account)
        {
            Open();

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

            Close();
        }

        public void DeleteAccountData(Account account)
        {
            Open();

            var cmd = new MySqlCommand();
            cmd.Connection = _connection;
            cmd.CommandText =
                "Delete from Account where Id = @Id";

            cmd.Parameters.AddWithValue("@Id", account.Id);
            cmd.ExecuteNonQuery();

            Close();
        }
        
        public List<Account> ReadAccountData()
        {
            Open();

            var cmd = new MySqlCommand();
            cmd.Connection = _connection;
            cmd.CommandText = $"Select * from Account where OwnerId = {User.Id}";

            var reader = cmd.ExecuteReader();

            if (!reader.HasRows)
            {
                Close();
                return new List<Account>();
            }

            var accountsList = new List<Account>();

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

            Close();
            
            return accountsList;
        }

        public decimal GetBalanceSum(uint OwnerId)
        {
            Open();

            var cmd = new MySqlCommand();
            
            cmd.Connection = _connection;
            cmd.CommandText = $"Select Sum(Amount) from Account where OwnerId = {User.Id}";
            
            var balance = (decimal)cmd.ExecuteScalar();

            Close();
            
            return balance;
        }
    }
}