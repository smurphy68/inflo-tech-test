using System;
using System.Collections.Generic;
using System.Linq;
using MyApp.Models;

namespace MyApp.Data
{
    public class DataAccess : IDataAccess
    {
        public DataAccess(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        private readonly DataContext _dataContext;

        public IEnumerable<TEntity> GetAll<TEntity>() where TEntity : ModelBase
        {
            return _dataContext.Set<TEntity>().ConvertAll(p => p);
        }

        public TEntity GetById<TEntity>(int id) where TEntity : ModelBase
        {
            return GetAll<TEntity>().FirstOrDefault(p => p.Id.Equals(id));
        }

        public TEntity Create<TEntity>(TEntity entity) where TEntity : ModelBase
        {
            var items = this.GetAll<TEntity>();

            entity.Id = items.Max(p => p.Id) + 1;

            _dataContext.Set<TEntity>().Add(entity);

            return entity;
        }

        public TEntity Update<TEntity>(TEntity entity) where TEntity : ModelBase
        {
            var originalEtity = GetAll<TEntity>().FirstOrDefault(p => p.Id.Equals(entity.Id));

            if (originalEtity == null)
            {
                throw new NullReferenceException("The entity does not exist in the data store");
            }

            // remove the original entity
            _dataContext.Set<TEntity>().Remove(originalEtity);

            // add the updated entity
            _dataContext.Set<TEntity>().Add(entity);

            return entity;
        }

        public void Delete<TEntity>(TEntity entity) where TEntity : ModelBase
        {
            var originalEtity = GetAll<TEntity>().FirstOrDefault(p => p.Id.Equals(entity.Id));

            if (originalEtity == null)
            {
                throw new NullReferenceException("The entity does not exist in the data store");
            }

            // remove the original entity
            _dataContext.Set<TEntity>().Remove(originalEtity);
        }
    }
}
