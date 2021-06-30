using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Kirtasiye.Shared.Data.Abstract;
using Kirtasiye.Shared.Entities.Abstract;

namespace Kirtasiye.Shared.Data.Concrete
{
    public class EfEntityRepositoryBase<T>:IEntityRepository<T>
        
    where T:class,IEntity,new()

    {
        private readonly DbContext _context;
        public EfEntityRepositoryBase(DbContext context )
        {
            _context = context;
        }
        public List<T> GetAll(Expression<Func<T, bool>> filter = null)
        {
            if (filter==null)
            {
              return  _context.Set<T>().ToList();
            }
            else
            {
                return _context.Set<T>().Where(filter).ToList();
            }
               
        }

        public T Get(Expression<Func<T, bool>> filter)
        {

            return _context.Set<T>().SingleOrDefault(filter);
        }

        public T Add(T entity)
        {
            var addedEntity = _context.Entry(entity);
            addedEntity.State = EntityState.Added;
            _context.SaveChanges();
            return entity;

        }

        public T Delete(T entity)
        {
            var deletedEntity = _context.Entry(entity);
            deletedEntity.State = EntityState.Deleted;
            _context.SaveChanges();
            return entity;

        }

        public T Update(T entity)
        {
            var updatedEntity = _context.Entry(entity);
            updatedEntity.State = EntityState.Modified;
            _context.SaveChanges();
            return entity;

        }
    }
}
