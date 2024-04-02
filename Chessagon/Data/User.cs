namespace Chessagon.Data
{
    public class User
    {
        public int Id { get; set; }
        public int Rating { get; set; }
        public string Username { get; set; }
        public string Password { get; set; } //TODO: add hashing!
        public string Email { get; set; }
        public string Description { get; set; }
        public string Role { get; set; } //admin user etc to be added
        public virtual ICollection<Game> GameHistory { get; set; }
    }
}
