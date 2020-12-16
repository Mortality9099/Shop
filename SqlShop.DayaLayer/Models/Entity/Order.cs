using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlShop.DayaLayer.Models.Entity
{
    public class Order
    {
        [Key]
        public long OrderId { get; set; }

        [Required]
        [MaxLength(6)]
        public string OrderCode { get; set; }

        [Required]
        [MaxLength(10)]
        public string OrderDate { get; set; }

        public decimal FinallPrice { get; set; }

        [ForeignKey("Customer")]
        public long CustomerId { get; set; }

        public Customer Customer { get; set; }

        public ICollection<OrderDetails> OrderDetails { get; set; }

        public Order()
        {
            OrderDetails = new List<OrderDetails>();
        }
    }
}
