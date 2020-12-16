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
    public class OrderDetailsViewModel : IEntityViewModel<OrderDetails>
    {
        public void InsertEntity(OrderDetails entity)
        {
            using (ShopDataBaseContext EntityContext = new ShopDataBaseContext())
            {
                EntityContext.OrderDetails.Add(entity);
                EntityContext.SaveChanges();
            }
        }

        public void ModifyEntity(OrderDetails entity)
        {
            using (ShopDataBaseContext EntityContext = new ShopDataBaseContext())
            {
                EntityContext.OrderDetails.Attach(entity);
                EntityContext.SaveChanges();
            }
        }

        public void RemoveEntity(OrderDetails entity)
        {
            // TODO: Remove the OrderDetail from the main list and the list in the Order
            using (ShopDataBaseContext EntityContext = new ShopDataBaseContext())
            {
                //EntityContext.OrderDetails.Remove(entity);
                EntityContext.OrderDetails.Attach(entity);
                EntityContext.Entry(entity).State = EntityState.Deleted;
                EntityContext.SaveChanges();
            }
        }

        public ICollection<OrderDetails> GetAllEntities()
        {
            using (ShopDataBaseContext EntityContext = new ShopDataBaseContext())
            {
                return EntityContext.OrderDetails.ToList();
            }
        }

        public ICollection<OrderDetails> GetAllEntities(Order order)
        {
            using (ShopDataBaseContext EntityContext = new ShopDataBaseContext())
            {
                List<OrderDetails> orderDetails = new List<OrderDetails>();
                foreach (var item in GetAllEntities())
                {
                    if (item.OrderId == order.OrderId)
                        orderDetails.Add(item);
                }
                return orderDetails;
            }
        }

        public OrderDetails GetEntity(long EntityId)
        {
            using (ShopDataBaseContext EntityContext = new ShopDataBaseContext())
            {
                foreach (var OrderDetails in GetAllEntities())
                {
                    if (OrderDetails.OrderDetailsId == EntityId)
                        return OrderDetails;
                }
                return null;
            }
        }
    }
}
