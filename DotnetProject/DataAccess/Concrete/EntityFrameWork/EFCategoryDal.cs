using System.Linq.Expressions;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFCategoryDal : EFentityRepositoryBase<Category, NorthwindContext>, ICategoryDal

    {
      
    }
}