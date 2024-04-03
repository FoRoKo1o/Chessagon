using Chessagon.Data;
using System.ComponentModel.DataAnnotations;

namespace Chessagon.DTO.User
{
    public class CreateUserDto : BaseUserDto
    {
        /*
         * Note to SEGMK:
         * DTOs are used to transfer data between software application subsystems.
         * We dont want to expose the User object to the client, so we use DTOs to transfer data.
         * That way we can ignore some fields that we dont want to expose to the client like id. Even if client sends an id, we ignore it.
         */
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
}
