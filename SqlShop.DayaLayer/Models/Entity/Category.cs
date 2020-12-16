using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlShop.DayaLayer.Models.Entity
{
    public class Category
    {
        [Key]
        public long CategoryId { get; set; }

        [Required]
        [MaxLength(50)]
        public string CategoryName { get; set; }

        public ICollection<Product> Products { get; set; }

        public Category()
        {
            Products = new List<Product>();
        }

        public Category(string categoryName)
            : base()
        {
            CategoryName = categoryName;
        }

        #region -----  Equals and GetHashCode  -----

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Category))
                return false;

            Category category = obj as Category;

            return CategoryName.Equals(category.CategoryName);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        #endregion
    }
}
