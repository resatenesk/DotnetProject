using System;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

class Program
{
    static void Main()
    {
        ProductManager productManager = new ProductManager(new EFProductDal());
        var result = productManager.GetProductDetails();
        if (result.Success)
        {
            foreach (var product in result.Data)
            {
                Console.WriteLine(product.ProductName + "/" + product.CategoryName);
            }

        }
        else
        {
            Console.WriteLine(result.Message);
        }


    }
}
