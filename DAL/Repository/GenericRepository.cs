using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        T FindById(int id);
        IEnumerable<T> GetAll();
        void Create(T item);
        void Remove(int id);
        void Update(T item);
    }
    public class GenericRepository<T> : IGenericRepository<T>, IDisposable where T : class
    {
        private readonly MyContext _ctx;
        DbSet<T> _dbSet;
        public GenericRepository()
        {
            _ctx = new MyContext();
            _dbSet = _ctx.Set<T>();
        }

        public void Create(T item)
        {
            _ctx.Set<T>().Add(item);
            _ctx.SaveChanges();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public T FindById(int id)
        {
            var search = _ctx.Set<T>().Find(id);

            return search;
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet.AsNoTracking();
            //var searachRes = _ctx.Set<T>().AsNoTracking().ToList();

            //return searachRes;
        }

        public void Remove(int id)
        {
            var tEntity = _ctx.Set<T>().Find(id);
            _ctx.Set<T>().Remove(tEntity);
            _ctx.SaveChanges();
        }

        public void Update(T item)
        {
            _ctx.Set<T>().AddOrUpdate(item);
            _ctx.SaveChanges();
        }
    }
}
