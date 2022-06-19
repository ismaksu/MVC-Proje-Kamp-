using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        Context c = new Context();
        DbSet<T> _object;

        public GenericRepository()
        {
            _object = c.Set<T>();
        }

        public void Ekle(T p)
        {
            _object.Add(p);
            c.SaveChanges();
        }

        public void Guncelle(T p)
        {
            c.SaveChanges();
        }

        public List<T> Listele()
        {
            return _object.ToList();
        }

        public List<T> Listele(Expression<Func<T, bool>> filtre)
        {
            return _object.Where(filtre).ToList();
        }

        public void Sil(T p)
        {
            _object.Remove(p);
            c.SaveChanges();
        }
    }
}
