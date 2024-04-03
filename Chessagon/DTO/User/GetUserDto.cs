using Chessagon.DTO.Game;
using Newtonsoft.Json;

namespace Chessagon.DTO.User
{
    public class GetUserDto : BaseUserDto
    {
        public int Id { get; set; }
        public int Rating { get; set; }
    }
    public class GetUserDetailsDto : GetUserDto
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public List<GetGameDto> GameHistory { get; set; }
    }
}
