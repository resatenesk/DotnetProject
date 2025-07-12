using Core.Entities;
namespace Entities.DTOs
{
    public class ProductDetailDto : Idto
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string CategoryName { get; set; }
        public short UnitsInStock { get; set; }
    }
}