using System.ComponentModel.DataAnnotations;

namespace Chessagon.DTO.Game
{
    public abstract class BaseGameDto
    {
        [Required]
        public int UserId { get; set; }
        [Required]
        public int Player1Id { get; set; }
        [Required]
        public int Player2Id { get; set; }
        [Required]
        public int? WinnerId { get; set; }
        [Required]
        [Range(1, int.MaxValue)]
        public int ratingChange { get; set; }
    }
}
