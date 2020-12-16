using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlShop.DayaLayer.Models.Entity
{
    public class Customer
    {
        [Key]
        public long CustomerId { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(14)]
        public string PhoneNumber { get; set; }

        [Required]
        [EmailAddress]
        [MaxLength(150)]
        public string Email { get; set; }

        [Required]
        [MaxLength(250)]
        public string Address { get; set; }

        public byte IsActive { get; set; }

        public ICollection<Order> Orders { get; set; }

        public string this[int i]
        {
            get
            {
                switch(i)
                {
                    case 0:
                        return CustomerId.ToString();
                    case 1:
                        return FirstName;
                    case 2:
                        return LastName;
                    case 3:
                        return PhoneNumber;
                    case 4:
                        return Email;
                    case 5:
                        return Address;
                    case 6:
                        return IsActive.ToString();
                    default:
                        return string.Empty;
                }
            }
        }

        #region -----  Constructors  -----

        public Customer(string firstName, string lastName, string phoneNumber, string emailAddress
            , string address) : base()
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Email = emailAddress;
            Address = address;
        }

        public Customer()
        {
            IsActive = 0;
            Orders = new List<Order>();
        }

        #endregion

        #region -----  Equals and HashCode  -----

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            if (!(obj is Customer))
                return false;

            var customer = obj as Customer;
            return customer.FirstName.Equals(FirstName)
                && customer.LastName.Equals(LastName)
                && customer.PhoneNumber.Equals(PhoneNumber);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        #endregion

        public override string ToString() => FirstName + LastName;
    }
}
