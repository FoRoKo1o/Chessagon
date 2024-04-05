using Chessagon.DTO.User;
using Microsoft.AspNetCore.Identity;

namespace Chessagon.Contracts
{
    public interface IAuthManager
    {
        Task<IEnumerable<IdentityError>> Register(CreateUserDto userDto);
        Task<AuthResponseDto> Login(LoginDto userDto);
        Task<String> CreateRefreshToken();
        Task<AuthResponseDto> VerifyRefreshToken(AuthResponseDto request);
    }
}
