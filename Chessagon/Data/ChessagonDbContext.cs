using Microsoft.EntityFrameworkCore;

namespace Chessagon.Data
{
    public class ChessagonDbContext : DbContext
    {
        public ChessagonDbContext(DbContextOptions<ChessagonDbContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Game> Games { get; set; }

        //data seeding for testing
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Username = "admin", Password = "admin", Email = "admin@admin.com", Description = "I'm admin", Rating = 9999, Role = "admin" },
                new User { Id = 2, Username = "user", Password = "user", Email = "user@user.com", Description = "I'm user", Rating = 0, Role = "user" }
            );
            modelBuilder.Entity<Game>().HasData(
                new Game { Id = 1, UserId = 1, Player1Id = 1, Player2Id = 2, WinnerId = 2, ratingChange = 10 },
                new Game { Id = 2, UserId = 1, Player1Id = 1, Player2Id = 2, WinnerId = 1, ratingChange = 10 },
                new Game { Id = 3, UserId = 2, Player1Id = 2, Player2Id = 1, WinnerId = null, ratingChange = 0 }
            );
        }
    }
}
