using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Chessagon.Data.Configuration
{
    public class GameConfiguration : IEntityTypeConfiguration<Game>
    {
        //TODO: Data seeding
        public void Configure(EntityTypeBuilder<Game> builder)
        {
            builder.HasData(
                new Game
                {
                    Id = 1,
                    Player1Id = "1",
                    Player2Id = "2",
                    WinnerId = "1",
                    RatingChange = 10,
                    Date = new DateTime(2020, 1, 1)
                },
                new Game
                {
                    Id = 2,
                    Player1Id = "2",
                    Player2Id = "1",
                    WinnerId = "2",
                    RatingChange = 10,
                    Date = new DateTime(2020, 1, 2),
                                        
                }
            );
        }
    }
}
