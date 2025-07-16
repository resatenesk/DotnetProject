using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.VisualBasic.FileIO;

namespace Business.Abstract
{
    public interface IProductService
    {
        IDataResult<List<Product>> GetAll();
        IDataResult<List<Product>> GetAllByCategoryID(int id);
        IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max);
        IDataResult<List<Product>> GetByUnitsInStock(decimal min, decimal max);
        IDataResult<List<ProductDetailDto>> GetProductDetails();
        IDataResult<Product> GetById(int productID);
        IResult Add(Product product);
        IResult Update(Product product);



    }
}