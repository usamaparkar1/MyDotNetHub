namespace MyDotNetHub.Models
{
    public class User
    {
        public int Id { get; set; } // primary key
        public string Name { get; set; } = null!; // SQLite TEXT
        public string Email { get; set; } = null!;
    }
}