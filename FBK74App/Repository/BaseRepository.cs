using FBK74App.Interface;
using FBK74App.models;
using Microsoft.EntityFrameworkCore;

namespace FBK74App.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : class
    {
        private readonly AppDbContext _context;
        private readonly DbSet<T> _dbSet;

        public BaseRepository(AppDbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public T Add(T entity)
        {
            _dbSet.Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public void Update(T entity)
        {
            _dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(T entity)
        {
            if (_context.Entry(entity).State == EntityState.Detached)
            {
                _dbSet.Attach(entity);
            }
            _dbSet.Remove(entity);
            _context.SaveChanges();
        }

        public T? GetById(Guid id)
        {
            return _dbSet.Find(id);
        }

        public IEnumerable<T> GetAll(string? searchKey = null, int page = 1, int pageSize = 10)
        {
            IQueryable<T> query = _dbSet;

            if (!string.IsNullOrEmpty(searchKey))
            {
                query = query.Where(e => EF.Property<string>(e, "Name").Contains(searchKey));
            }

            return query.Skip((page - 1) * pageSize).Take(pageSize).ToList();
        }
    } 
}
