using System;
using System.Collections.Generic;
using MyApp.Models;

namespace MyApp.Data
{
    public interface IDataAccess
    {
        /// <summary>
        /// Get a list of items
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <returns></returns>
        IEnumerable<TEntity> GetAll<TEntity>() where TEntity : ModelBase;

        /// <summary>
        /// Get an item that matches the ID
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="id"></param>
        /// <returns></returns>
        TEntity GetById<TEntity>(int id) where TEntity : ModelBase;

        /// <summary>
        /// Create a new item
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="entity"></param>
        /// <returns></returns>
        TEntity Create<TEntity>(TEntity entity) where TEntity : ModelBase;


        /// <summary>
        /// Uodate an existing item matching the ID
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="entity"></param>
        /// <returns></returns>
        TEntity Update<TEntity>(TEntity entity) where TEntity : ModelBase;

        void Delete<TEntity>(TEntity entity) where TEntity : ModelBase;
    }
}
