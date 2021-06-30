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
    public class EfCartDal:EfEntityRepositoryBase<Cart>,ICartDal
    {
        public EfCartDal(DbContext context) : base(context)
        {
        }
    }
}
