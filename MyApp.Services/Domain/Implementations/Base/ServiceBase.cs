using System.Collections.Generic;
using MyApp.Data;
using MyApp.Models;
using MyApp.Services.Domain.Interfaces.Base;

namespace MyApp.Services.Domain.Implementations.Base
{
    public abstract class ServiceBase<TEntity> : IServiceBase<TEntity>
        where TEntity : ModelBase
    {
        protected ServiceBase(IDataAccess dataAccess)
        {
            DataAccess = dataAccess;
        }

        private IDataAccess DataAccess { get; }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return DataAccess.GetAll<TEntity>();
        }

        public virtual TEntity GetById(int id)
        {
            return DataAccess.GetById<TEntity>(id);
        }

        public virtual TEntity Create(TEntity entity)
        {
            return DataAccess.Create(entity);
        }

        public virtual TEntity Update(TEntity entity)
        {
            return DataAccess.Update(entity);
        }

        public virtual void Delete(TEntity entity)
        {
            DataAccess.Delete(entity);
        }
    }
}
