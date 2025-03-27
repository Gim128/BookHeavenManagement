using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHeavenManagement.Models
{
    public class Sale
    {
        public int SaleID { get; set; }
        public int CustomerID { get; set; }
        public int UserID { get; set; }
        public DateTime SaleDate { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal Discount { get; set; }
        public string PaymentMethod { get; set; }
    }

    public class SaleItem
    {
        public int SaleItemID { get; set; }
        public int SaleID { get; set; }
        public int BookID { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
