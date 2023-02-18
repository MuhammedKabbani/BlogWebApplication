using DataAccessLayer.Abstract;
using DataAccessLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        Context _context;

        public Repository()
        {
            _context = new Context();
        }

        public void Add(T t)
        {
            _context.Add(t);
            _context.SaveChanges();
        }

        public void Delete(T t)
        {
            _context.Remove(t);
            _context.SaveChanges();
        }

        public T Get(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public List<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

		public List<T> GetAll(Expression<Func<T, bool>> expression)
		{
			return _context.Set<T>().Where(expression).ToList();
		}

		public void Update(T t)
        {
            _context.Update(t);
            _context.SaveChanges();
        }
    }
}
