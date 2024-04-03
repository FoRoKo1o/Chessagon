using Chessagon.Data;

namespace Chessagon.Contracts
{
    public interface IUserRepository : IGenericRepository<User>
    {
        Task<User> GetUserDetails(int id);
    }
}
