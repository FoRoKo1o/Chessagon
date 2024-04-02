using System.ComponentModel.DataAnnotations.Schema;

namespace Chessagon.Data
{
    public class Game
    {
        public int Id { get; set; }
        public int UserId { get; set; } // game host id (lets say always white player)
        [ForeignKey(nameof(Player1Id))]
        public int Player1Id { get; set; }
        [ForeignKey(nameof(Player2Id))]
        public int Player2Id { get; set; }
        public int? WinnerId { get; set; } //if null, its a draw
        public int ratingChange { get; set; } // same for both players
    }
}
