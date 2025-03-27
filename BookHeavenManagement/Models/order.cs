using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHeavenManagement.Models
{
    public class order
    {
        public int OrderID { get; set; }
        public int SupplierID { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.Now;
        public DateTime? ExpectedDeliveryDate { get; set; }
        public string Status { get; set; } = "Pending";
        public decimal TotalAmount { get; set; }
    }

    public class OrderItem
    {
        public int OrderItemID { get; set; }
        public int OrderID { get; set; }
        public int BookID { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
