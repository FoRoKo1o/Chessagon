using Chessagon.Contracts;
using Chessagon.Data;

namespace Chessagon.Repository
{
    public class GameRepository : GenericRepository<Game>, IGameRepository
    {
        public GameRepository(ChessagonDbContext context) : base(context)
        {
        }
    }
}
