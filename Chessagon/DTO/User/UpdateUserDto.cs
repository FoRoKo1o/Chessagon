namespace Chessagon.DTO.User
{
    public class UpdateUserDto : BaseUserDto
    {
        //TODO: Refactor update, add endpoints for updating password, email, description, role etc
        public int Id { get; set; }
        public int Rating { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }
        public string Role { get; set; }
    }
}
