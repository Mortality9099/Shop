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
    public class ProductViewModel : IEntityViewModel<Product>
    {
        public void InsertEntity(Product entity)
        {
            using (ShopDataBaseContext EntityContext = new ShopDataBaseContext())
            {
                EntityContext.Products.Add(entity);
                EntityContext.SaveChanges();
            }
        }

        public void RemoveEntity(Product entity)
        {
            using (ShopDataBaseContext EntityContext = new ShopDataBaseContext())
            {
                //EntityContext.Products.Remove(entity);
                EntityContext.Products.Attach(entity);
                EntityContext.Entry(entity).State = EntityState.Deleted;
                EntityContext.SaveChanges();
            }
        }

        public void ModifyEntity(Product entity)
        {
            using (ShopDataBaseContext EntityContext = new ShopDataBaseContext())
            {
                EntityContext.Products.Attach(entity);
                EntityContext.Entry(entity).State = EntityState.Modified;
                EntityContext.SaveChanges();
            }
        }

        public ICollection<Product> GetAllEntities()
        {
            using (ShopDataBaseContext EntityContext = new ShopDataBaseContext())
            {
                return EntityContext.Products.ToList();
            }
        }

        public ICollection<Product> GetAllNonDeletedEntities()
        {
            using (ShopDataBaseContext EntityContext = new ShopDataBaseContext())
            {
                List<Product> NonDeletedProducts = new List<Product>();
                foreach (var Product in GetAllEntities())
                {
                    if (Product.IsActive == 0)
                        NonDeletedProducts.Add(Product);
                }

                return NonDeletedProducts;
            }
        }

        // Get all products in a same category
        public ICollection<Product> GetAllEntities(Category category)
        {
            using (ShopDataBaseContext EntityContext = new ShopDataBaseContext())
            {
                List<Product> Products = new List<Product>();
                foreach (var product in GetAllNonDeletedEntities())
                {
                    if (product.CategoryId == category.CategoryId)
                        Products.Add(product);
                }
                return Products;
            }
        }

        // Get all products with a same supplier
        public ICollection<Product> GetAllEntities(Supplier supplier)
        {
            using (ShopDataBaseContext EntityContext = new ShopDataBaseContext())
            {
                var SupplierProducts = new List<Product>();
                foreach (var product in GetAllEntities())
                {
                    if (product.SupplierId == supplier.SupplierId)
                        SupplierProducts.Add(product);
                }
                return SupplierProducts;
            }
        }

        public Product GetEntity(long EntityId)
        {
            using (ShopDataBaseContext EntityContext = new ShopDataBaseContext())
            {
                foreach (var Product in GetAllEntities())
                {
                    if (Product.ProductId == EntityId)
                        return Product;
                }
                return null;
            }
        }
    }
}
