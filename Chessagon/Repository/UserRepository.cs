using Chessagon.Contracts;
using Chessagon.Data;
using Microsoft.EntityFrameworkCore;

namespace Chessagon.Repository
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        private readonly ChessagonDbContext _context;

        //Note to SEGMK: GenericRepository have the basic CRUD operations, but we can add more specific methods here.
        public UserRepository(ChessagonDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<User> GetUserDetails(int id)
        {
            return await _context.Users.Include(u => u.GameHistory)
                .FirstOrDefaultAsync(u => u.Id == id.ToString());
        }
    }
}
