
namespace FBK74App.Interface
{
    public interface IRepository<T>
    {
        T Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        T? GetById(Guid id);
        IEnumerable<T> GetAll(string? searchKey = null, int page = 1, int pageSize = 10);
    }
}
