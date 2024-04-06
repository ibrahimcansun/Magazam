using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MagazamMVC.Models.Concrete
{
    public class SalesTransaction
    {
        [Key]
        public int SalesTransactionId { get; set; }
        public DateTime? SalesDate { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal TotalPrice { get; set; }

        public Product Product { get; set; }
        public Current Current { get; set; }
        public Employee Employee { get; set; }
    }
}