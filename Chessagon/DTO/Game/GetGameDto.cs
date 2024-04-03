using System.ComponentModel.DataAnnotations.Schema;

namespace Chessagon.DTO.Game
{
    public class GetGameDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int Player1Id { get; set; }
        public int Player2Id { get; set; }
        public int? WinnerId { get; set; }
        public int ratingChange { get; set; }
    }
}
