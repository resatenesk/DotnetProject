using System.Linq;
using System.Linq.Expressions;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFCustomerDal : EFentityRepositoryBase<Customer, NorthwindContext>, ICustomerDal
    {
      
    }
}