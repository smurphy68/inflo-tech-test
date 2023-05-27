using System.Collections.Generic;
using MyApp.Models;

namespace MyApp.Services.Domain.Interfaces.Base
{
    public interface IServiceBase<TEntity> where TEntity : ModelBase
    {
        IEnumerable<TEntity> GetAll();

        TEntity GetById(int id);

        TEntity Create(TEntity entity);

        TEntity Update(TEntity entity);

        void Delete(TEntity entity);
    }
}