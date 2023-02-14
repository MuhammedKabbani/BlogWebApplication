using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRepository<T> where T : class
    {
        public void Add(T t);
        public void Update(T t);
        public void Delete(T t);
        public T Get(int id);
        public List<T> GetAll();
    }
}
