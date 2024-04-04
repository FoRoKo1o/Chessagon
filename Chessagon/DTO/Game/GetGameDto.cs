using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace Chessagon.DTO.Game
{
    public class GetGameDto : BaseGameDto
    {
        public int Id { get; set; }
    }
}
