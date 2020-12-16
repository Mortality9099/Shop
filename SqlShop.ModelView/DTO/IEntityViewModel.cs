using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlShop.DayaLayer.Models.Context;
using SqlShop.DayaLayer.Models.Entity;

namespace SqlShop.ModelView.DTO
{
    public interface IEntityViewModel<TEntity> where TEntity : class 
    {
        // Add a new Entity to data base
        void InsertEntity(TEntity entity);

        // Remove an Entity from data base and save changes
        void RemoveEntity(TEntity entity);

        // Modify an Entity's information and save changes
        void ModifyEntity(TEntity entity);

        // Get all Non-Deleted Entity from data base
        ICollection<TEntity> GetAllEntities();

        // Get the Entity by its ID
        TEntity GetEntity(long EntityId);
    }
}
