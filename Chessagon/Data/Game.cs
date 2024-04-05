using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Chessagon.Data
{
    public class Game
    {
        public int Id { get; set; }

        // Id gracza 1
        [Required]
        public string Player1Id { get; set; }
        [ForeignKey("Player1Id")]
        public virtual User Player1 { get; set; }

        // Id gracza 2
        [Required]
        public string Player2Id { get; set; }
        [ForeignKey("Player2Id")]
        public virtual User Player2 { get; set; }

        // Id gracza, który wygrał grę
        public string WinnerId { get; set; } // zmiana typu na string
        [ForeignKey("WinnerId")]
        public virtual User Winner { get; set; }

        // Jeśli null, to remis
        public int? RatingChange { get; set; }

        // Data gry
        public DateTime Date { get; set; }
    }
}
