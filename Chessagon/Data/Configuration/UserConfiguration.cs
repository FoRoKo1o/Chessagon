using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Chessagon.Data.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(
                new User
                {
                    Id = "1",
                    UserName = "admin",
                    Email = "admin@admin",
                    EmailConfirmed = true,
                    PasswordHash = "admintest",
                    Rating = 9999,
                    IsSoftDeleted = false
                },
                new User
                {
                    Id = "2",
                    UserName = "user",
                    Email = "user@user",
                    EmailConfirmed = true,
                    PasswordHash = "usertest",
                    Rating = 200,
                    IsSoftDeleted = false
                },
                new User
                {
                    Id = "3",
                    UserName = "user",
                    Email = "user@user",
                    EmailConfirmed = true,
                    PasswordHash = "usertest",
                    Rating = 200,
                    IsSoftDeleted = true
                }
            );
        }
    }
}
