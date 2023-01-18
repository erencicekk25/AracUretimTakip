using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using UretimTakip.DataAccess;

namespace UretimTakip.Business.Concrete
{
    public class SqlRepository<T> : IRepository<T> where T : class
    {
        xContext _context = new xContext(); //Veritabanına erişmek için Context sınıfımızı örnekledik

        public SqlRepository()
        {
        }


        public void Add(T entity)
        {
            _context.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(T entity)
        {
            _context.Remove(entity);
            _context.SaveChanges();
        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>();
        }

        public IQueryable<T> GetAll(Expression<Func<T, bool>> expression)
        {
            return _context.Set<T>().Where(expression); //linq lambda ile sorgulamamıza imkan tanıyor
        }

        public T GetBy(Expression<Func<T, bool>> expression)
        {
            return _context.Set<T>().FirstOrDefault(expression); //linq lambda ile sorgulamamıza imkan tanıyor
        } 

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public void Update(T entity)
        {
            _context.Update(entity);
            _context.SaveChanges();
        }
    }
}
