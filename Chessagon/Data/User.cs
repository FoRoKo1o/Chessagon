using Microsoft.AspNetCore.Identity;

namespace Chessagon.Data
{
    public class User : IdentityUser
    {
        //TODO: Remove some fields from here, we have IdentityUser
        //TODO: FIX GameHistory

        //public int Id { get; set; }
        //public string Username { get; set; }
        //public string Password { get; set; } //TODO: add hashing!
        //public string Email { get; set; }
        //public string Role { get; set; } //admin user etc to be added
        public bool IsSoftDeleted { get; set; }
        public string? Description { get; set; }
        public int Rating { get; set; }
        public virtual ICollection<Game>? GameHistory { get; set; }
    }
}
