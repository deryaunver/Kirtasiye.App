using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kirtasiye.Entities.Database;
using Kirtasiye.Shared.Data.Abstract;

namespace Kirtasiye.DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
        
    }
}
