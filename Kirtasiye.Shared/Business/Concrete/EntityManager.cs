using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Kirtasiye.Shared.Business.Abstract;
using Kirtasiye.Shared.Data.Abstract;
using Kirtasiye.Shared.Entities.Abstract;

namespace Kirtasiye.Shared.Business.Concrete
{
    public class EntityManager<T>:IEntityService<T>
        where T : class, IEntity, new()
    {
        private readonly IEntityRepository<T> _entityRepository;

        public EntityManager(IEntityRepository<T> entityRepository)
        {
         _entityRepository = entityRepository;
        }

        public List<T> GetAll(Expression<Func<T, bool>> filter = null)
        {
            return _entityRepository.GetAll(filter).ToList();
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            return _entityRepository.Get(filter);
        }

        public T Add(T entity)
        {
            return _entityRepository.Add(entity);
        }

        public T Delete(T entity)
        {
            return _entityRepository.Delete(entity);
        }

        public T Update(T entity)
        {
            return _entityRepository.Update(entity);
        }
    }
}
