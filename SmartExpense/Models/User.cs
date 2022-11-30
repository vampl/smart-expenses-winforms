using System.Collections.Generic;

namespace SmartExpense.Models
{
    public class User
    {
        public uint Id { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }

        private List<Account> _accounts = null;
        private List<Transaction> _transactions = null;
    }
}