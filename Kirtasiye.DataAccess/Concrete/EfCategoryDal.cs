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
    public class EfCategoryDal:EfEntityRepositoryBase<Category>,ICategoryDal
    {
        public EfCategoryDal(DbContext context) : base(context)
        {
        }
    }
}
