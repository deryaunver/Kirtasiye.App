using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kirtasiye.DataAccess.Abstract;
using Kirtasiye.Entities.Database;
using Kirtasiye.Shared.Data.Concrete;

namespace Kirtasiye.DataAccess.Concrete
{
    public class EfProductDal:EfEntityRepositoryBase<Product>,IProductDal
    {
        public EfProductDal(DbContext context) : base(context)
        {
        }
    }
}
