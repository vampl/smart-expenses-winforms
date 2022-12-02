namespace SmartExpense.Models
{
    // unique user record for all project.
    public class User
    {
        public static uint Id { get; set; }
        public static string Password { get; set; }
        public static string Name { get; set; }

        public User(uint id, string password, string name)
        {
            Id = id;
            Password = password;
            Name = name;
        }
    }
}