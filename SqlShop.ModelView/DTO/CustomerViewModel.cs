using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlShop.DayaLayer.Models.Context;
using SqlShop.DayaLayer.Models.Entity;

namespace SqlShop.ModelView.DTO
{
    public class CustomerViewModel : IEntityViewModel<Customer>
    {
        public void InsertEntity(Customer entity)
        {
            using (ShopDataBaseContext EntityContext = new ShopDataBaseContext())
            {
                EntityContext.Customers.Add(entity);
                EntityContext.SaveChanges();
            }
        }

        //   Hint:The path is to set the IsActive property to 1 and we know that if a 
        // property's IsActive value is 1, it is a deleted entity.
        public void RemoveEntity(Customer entity)
        {
            using (ShopDataBaseContext EntityContext = new ShopDataBaseContext())
            {
                //entity.IsActive = 1;
                //EntityContext.Customers.Attach(entity);
                //EntityContext.Entry(entity).State = EntityState.Modified;
                //EntityContext.Customers.Remove(entity);
                EntityContext.Customers.Attach(entity);
                EntityContext.Entry(entity).State = EntityState.Deleted;
                EntityContext.SaveChanges();
            }
        }

        public void ModifyEntity(Customer entity)
        {
            using (ShopDataBaseContext EntityContext = new ShopDataBaseContext())
            {
                EntityContext.Customers.Attach(entity);
                EntityContext.Entry(entity).State = EntityState.Modified;
                EntityContext.SaveChanges();
            }
        }

        public ICollection<Customer> GetAllEntities()
        {
            using (ShopDataBaseContext EntityContext = new ShopDataBaseContext())
            {
                return EntityContext.Customers.ToList();
            }
        }

        // Get all Customers that the value of IsActive is Zero
        // (It means they are not deleted from the data base)
        public ICollection<Customer> GetAllNonDeletedEntities()
        {
            using (ShopDataBaseContext EntityContext = new ShopDataBaseContext())
            {
                List<Customer> NonDeletedCustomers = new List<Customer>();
                foreach (var Customer in GetAllEntities())
                {
                    if (Customer.IsActive == 0)
                        NonDeletedCustomers.Add(Customer);
                }
                return NonDeletedCustomers;
            }
        }

        public Customer GetEntity(long EntityId)
        {
            using (ShopDataBaseContext EntityContext = new ShopDataBaseContext())
            {
                foreach (var Customer in GetAllEntities())
                {
                    if (Customer.CustomerId == EntityId)
                        return Customer;
                }
                return null;
            }
        }
    }
}
