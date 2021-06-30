using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kirtasiye.Business.Abstract;
using Kirtasiye.Entities.Database;
using Kirtasiye.Shared.Business.Concrete;
using Kirtasiye.Shared.Data.Abstract;

namespace Kirtasiye.Business.Concrete
{
    public class ProductManager:EntityManager<Product>,IProductService
    {
        public ProductManager(IEntityRepository<Product> entityRepository) : base(entityRepository)
        {
        }
    }
}
