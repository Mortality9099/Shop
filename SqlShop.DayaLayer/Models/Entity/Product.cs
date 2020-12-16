using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlShop.DayaLayer.Models.Entity
{
    public class Product
    {
        [Key]
        public long ProductId { get; set; }

        [Required]
        [MaxLength(100)]
        public string ProductName { get; set; }
        
        [Required]
        public decimal UnitPrice { get; set; }

        [Required]
        public decimal Qty { get; set; }

        public decimal Discount { get; set; }

        public byte IsActive { get; set; }
        
        [ForeignKey("Supplier")]
        public long SupplierId { get; set; }

        public Supplier Supplier { get; set; }

        [ForeignKey("Category")]
        public long CategoryId { get; set; }

        public Category Category { get; set; }

        public Product(string productName, decimal unitPrice, decimal qty, decimal discount, 
            long categoryId, long supplierId) : base()
        {
            ProductName = productName;
            UnitPrice = unitPrice;
            Qty = qty;
            Discount = discount;
            CategoryId = categoryId;
            SupplierId = supplierId;
        }

        public Product()
        {
            IsActive = 0;
        }

        #region -----  Equals and GetHashCode  -----
        public override bool Equals(object obj)
        {
            if (obj == null) return false;

            if (!(obj is Product)) return false;

            Product product = obj as Product;

            return ProductName.Equals(product.ProductName) &&
                UnitPrice == product.UnitPrice &&
                SupplierId == product.SupplierId
                && CategoryId == product.CategoryId;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        #endregion

        public override string ToString() => ProductName;
    }
}
