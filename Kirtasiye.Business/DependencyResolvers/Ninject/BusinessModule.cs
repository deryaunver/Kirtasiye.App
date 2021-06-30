using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kirtasiye.Business.Abstract;
using Kirtasiye.Business.Concrete;
using Kirtasiye.DataAccess.Abstract;
using Kirtasiye.DataAccess.Concrete;
using Kirtasiye.Shared.Business.Abstract;
using Kirtasiye.Shared.Business.Concrete;
using Kirtasiye.Shared.Data.Abstract;
using Kirtasiye.Shared.Data.Concrete;
using Ninject.Modules;

namespace Kirtasiye.Business.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {

        public override void Load()
        {


            Bind<IProductService>().To<ProductManager>();
            Bind<IProductDal>().To<EfProductDal>();

            Bind<ICategoryService>().To<CategoryManager>();
            Bind<ICategoryDal>().To<EfCategoryDal>();

            Bind<ICartService>().To<CartManager>();
            Bind<ICartDal>().To<EfCartDal>();

        }
    }
}
