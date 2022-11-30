using System;

namespace SmartExpense.Models
{
    public class Transaction
    {
        public uint OwnerId { get; set; }
        public uint Id { get; set; }
        public decimal Amount { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public string AccountTitle { get; set; }
    }
}