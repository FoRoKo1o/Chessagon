namespace Chessagon.Contracts
{
    public interface IGenericRepository<T> where T : class
    {
        /*
         Note to SEGMK: Repository is used as a pattern to separate the logic of the application from the data access layer.
        */
        Task<T> GetAsync(int? id);
        Task<List<T>> GetAllAsync();
        Task<T> AddAsync(T entity);
        Task DeleteAsync(int id);
        Task UpdateAsync(T entity);
        Task<bool> Exists(int id);
    }
}
