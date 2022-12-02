namespace SmartExpense.Models
{
    public class Account
    {
        public uint Id { get; set; }
        public uint OwnerId { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
    }
}