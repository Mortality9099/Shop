using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlShop.DayaLayer.Models.Entity
{
    public class OrderDetails
    {
        [Key]
        public long OrderDetailsId { get; set; }

        [Required]
        public decimal UnitPrice { get; set; }

        [Required]
        public decimal Qty { get; set; }

        public decimal Discount { get; set; }

        [ForeignKey("Order")]
        [Required]
        public long OrderId { get; set; }

        public Order Order { get; set; }

        [ForeignKey("Product")]
        [Required]
        public long ProductId { get; set; }

        public Product Product { get; set; }
    }
}
