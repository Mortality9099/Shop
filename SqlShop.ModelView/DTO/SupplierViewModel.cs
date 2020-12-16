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
    public class SupplierViewModel : IEntityViewModel<Supplier>
    {
        public void InsertEntity(Supplier entity)
        {
            using (ShopDataBaseContext EntityContext = new ShopDataBaseContext())
            {
                EntityContext.Suppliers.Add(entity);
                EntityContext.SaveChanges();
            }
        }

        public void ModifyEntity(Supplier entity)
        {
            using (ShopDataBaseContext EntityContext = new ShopDataBaseContext())
            {
                EntityContext.Suppliers.Attach(entity);
                EntityContext.Entry(entity).State = EntityState.Modified;
                EntityContext.SaveChanges();
            }
        }

        public void RemoveEntity(Supplier entity)
        {
            using (ShopDataBaseContext EntityContext = new ShopDataBaseContext())
            {
                //EntityContext.Suppliers.Remove(entity);
                EntityContext.Suppliers.Attach(entity);
                EntityContext.Entry(entity).State = EntityState.Deleted;
                EntityContext.SaveChanges();
            }
        }

        public ICollection<Supplier> GetAllEntities()
        {
            using (ShopDataBaseContext EntityContext = new ShopDataBaseContext())
            {
                return EntityContext.Suppliers.ToList();
            }
        }

        public Supplier GetEntity(long EntityId)
        {
            using (ShopDataBaseContext EntityContext = new ShopDataBaseContext())
            {
                foreach (var Supplier in GetAllEntities())
                {
                    if (Supplier.SupplierId == EntityId)
                        return Supplier;
                }
                return null;
            }
        }
    }
}
