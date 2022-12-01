using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SmartExpense.Database
{
    public class DatabaseController
    {
        // ToDo: thunk about data transfer between forms.
        private MySqlConnection _connection;

        public DatabaseController()
        {

        }
        
        public bool Open()  
        {  
            const string connectionString =
                "server=localhost;port=3306;user=root;password=root_password;database=SmartExpenseDatabase";
            try
            {
                _connection = new MySqlConnection();
                _connection.ConnectionString = connectionString;
                _connection.Open();
                return true;  
            }  
            catch (Exception er)  
            {  
                MessageBox.Show(@"Connection Error ! " + er.Message, @"Information");  
            }  
            return false;  
        }
            
        public void Close()  
        {  
            _connection.Close();  
            _connection.Dispose();  
        } 
        
        public DataSet ExecuteDataSet(string sql)  
        {  
            try  
            {  
                var ds = new DataSet();  
                var da = new MySqlDataAdapter(sql, _connection);  
                da.Fill(ds, "result");  
                return ds;  
            }  
            catch (Exception ex)  
            {  
                MessageBox.Show(ex.Message);  
            }  
            return null;  
        }  
  
        public MySqlDataReader ExecuteReader(string sql)  
        {  
            try  
            {  
                MySqlDataReader reader;  
                MySqlCommand cmd = new MySqlCommand(sql, _connection);  
                reader = cmd.ExecuteReader();  
                return reader;  
            }  
            catch (Exception ex)  
            {  
                MessageBox.Show(ex.Message);  
            }  
            return null;  
        }  
  
        public int ExecuteNonQuery(string sql)  
        {  
            try  
            {  
                int affected;  
                MySqlTransaction mytransaction = _connection.BeginTransaction();  
                MySqlCommand cmd = _connection.CreateCommand();  
                cmd.CommandText = sql;  
                affected = cmd.ExecuteNonQuery();  
                mytransaction.Commit();  
                return affected;  
            }  
            catch (Exception ex)  
            {  
                MessageBox.Show(ex.Message);  
            }  
            return -1;  
        } 
    }
}