using System.ComponentModel.DataAnnotations;

namespace Chessagon.DTO.User
{
    public abstract class BaseUserDto
    {
        public string Description { get; set; }
        public string Role { get; set; }
    }
}
