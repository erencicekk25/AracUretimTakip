using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace UretimTakip.Business
{
    public interface IRepository<T> 
    {
        public void Add(T entity);
        public void Update(T entity);
        public void Delete(T entity);
        public IEnumerable<T> GetAll();
        public T GetById(int id);
        public T GetBy(Expression<Func<T, bool>> expression);
    }
}
