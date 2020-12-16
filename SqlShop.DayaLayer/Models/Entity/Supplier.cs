using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlShop.DayaLayer.Models.Entity
{
    public class Supplier
    {
        [Key]
        public long SupplierId { get; set; }

        [MaxLength(100)]
        public string ContactName { get; set; }

        [MaxLength(300)]
        public string Address { get; set; }

        [MaxLength(14)]
        [Required]
        public string PhoneNumber { get; set; }

        public ICollection<Product> Products { get; set; }

        #region -----  Constructors  -----

        public Supplier()
        {
            Products = new List<Product>();
        }

        public Supplier(string contactName, string address, string phoneNumber)
        {
            ContactName = contactName;
            Address = address;
            PhoneNumber = phoneNumber;
        }

        #endregion

        #region -----  Equals and GetHashType  -----

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Supplier))
                return false;

            Supplier supplier = obj as Supplier;
            return supplier.ContactName.Equals(ContactName) &&
                supplier.PhoneNumber.Equals(PhoneNumber) &&
                supplier.Address.Equals(Address);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        #endregion
    }
}
