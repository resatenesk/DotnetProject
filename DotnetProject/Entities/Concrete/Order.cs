using Core.Entities;

namespace Entities.Concrete
{
    public class Order : IEntity
    {
        public int OrderID { get; set; }
        public string CustomerID { get; set; }
        public int EmployeeId { get; set; }
        public DateTime OrderDate { get; set; } 
        public string ShipCity { get; set; }
    }
}