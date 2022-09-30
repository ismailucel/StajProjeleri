using StockManagement.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement.DataAccess.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        Context _c = new Context();
        public void Delete(T t)
        {
            _c.Remove(t);
            _c.SaveChanges();
        }

        public T GetById(int id)
        {
            return _c.Set<T>().Find(id);
        }

        public List<T> GetAll()
        {
            return _c.Set<T>().ToList();
        }

        public void Add(T t)
        {
            _c.Add(t);
            _c.SaveChanges();
        }

        public void Update(T t)
        {
            _c.Update(t);
            _c.SaveChanges();
        }
    }
}
