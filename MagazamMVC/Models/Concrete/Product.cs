using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MagazamMVC.Models.Concrete
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        
        [Column(TypeName = "Varchar")]
        [StringLength(120)]
        public string ProductName { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string Brand { get; set; }
        public short Stock { get; set; }
        public decimal SellingPrice { get; set; }
        public decimal PurchasePrice { get; set; }
        public bool IsStock { get; set; }
        public string ProductImage { get; set; }
        public Category Category { get; set; }
        public ICollection<SalesTransaction> SalesTransactions { get; set; }
    }
}