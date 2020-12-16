using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlShop.DayaLayer.Models.Context;
using SqlShop.DayaLayer.Models.Entity;

namespace SqlShop.ModelView.DTO
{
    public class OrderViewModel : IEntityViewModel<Order>
    {
        public void InsertEntity(Order entity)
        {
            using (ShopDataBaseContext EntityContext = new ShopDataBaseContext())
            {
                EntityContext.Orders.Add(entity);
                EntityContext.SaveChanges();
            }
        }

        public void ModifyEntity(Order entity)
        {
            using (ShopDataBaseContext EntityContext = new ShopDataBaseContext())
            {
                EntityContext.Orders.Attach(entity);
                EntityContext.Entry(entity).State = EntityState.Modified;
                EntityContext.SaveChanges();
            }
        }

        public void RemoveEntity(Order entity)
        {
            // TODO: Order and order details should be deleted
            using (ShopDataBaseContext EntityContext = new ShopDataBaseContext())
            {
                //EntityContext.Orders.Remove(entity);
                EntityContext.Orders.Attach(entity);
                EntityContext.Entry(entity).State = EntityState.Deleted;
                EntityContext.SaveChanges();
            }
        }

        public ICollection<Order> GetAllEntities()
        {
            using (ShopDataBaseContext EntityContext = new ShopDataBaseContext())
            {
                return EntityContext.Orders.ToList();
            }
        }

        public Order GetEntity(long EntityId)
        {
            using (ShopDataBaseContext EntityContext = new ShopDataBaseContext())
            {
                foreach (var Order in GetAllEntities())
                {
                    if (Order.OrderId == EntityId)
                        return Order;
                }
                return null;
            }
        }
    }
}
