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
    public class CategoryViewModel : IEntityViewModel<Category>
    {
        public void InsertEntity(Category entity)
        {
            using (ShopDataBaseContext EntityContext = new ShopDataBaseContext())
            {
                EntityContext.Categories.Add(entity);
                EntityContext.SaveChanges();
            }
        }

        public void ModifyEntity(Category entity)
        {
            using (ShopDataBaseContext EntityContext = new ShopDataBaseContext())
            {
                EntityContext.Categories.Attach(entity);
                EntityContext.Entry(entity).State = EntityState.Modified;
                EntityContext.SaveChanges();
            }
        }

        public void RemoveEntity(Category entity)
        {
            // TODO : check if all the product exist in the category should be deleted or not
            using (ShopDataBaseContext EntityContext = new ShopDataBaseContext())
            {
                //EntityContext.Categories.Remove(entity);
                EntityContext.Categories.Attach(entity);
                EntityContext.Entry(entity).State = EntityState.Deleted;
                EntityContext.SaveChanges();
            }
        }

        public ICollection<Category> GetAllEntities()
        {
            using (ShopDataBaseContext EntityContext = new ShopDataBaseContext())
            {
                return EntityContext.Categories.ToList();
            }
        }

        public Category GetEntity(long EntityId)
        {
            using (ShopDataBaseContext EntityContext = new ShopDataBaseContext())
            {
                foreach (var Category in GetAllEntities())
                {
                    if (Category.CategoryId == EntityId)
                        return Category;
                }
                return null;
            }
        }
    }
}
