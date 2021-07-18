using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgriStore.Repositories.DAL
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private AgriStoreDbContext _context { get; set; }
        //private DbSet<T> 

        public Repository()
        {
            _context = new AgriStoreDbContext();
        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public T GetById(object id)
        {
            return _context.Set<T>().Find(id);
        }

        public void Insert(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public void Update(T entity)
        {
            _context.Set<T>().Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(object id)
        {
            T entity = _context.Set<T>().Find(id);
            _context.Set<T>().Remove(entity);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
