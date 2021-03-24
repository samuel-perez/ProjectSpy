namespace ProjectSpy.Storage.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;

    /// <summary>
    /// Repository
    /// </summary>
    /// <typeparam name="TEntity">Entity type</typeparam>
    public interface IRepository<TEntity>
        where TEntity : class
    {
        /// <summary>
        /// Deletes an entity
        /// </summary>
        /// <param name="entityToDelete">entity to delete</param>
        void Delete(TEntity entityToDelete);

        /// <summary>
        /// Deletes an entity by ID
        /// </summary>
        /// <param name="ids">IDs o the entity</param>
        void Delete(params object[] ids);

        /// <summary>
        /// Performs a select
        /// </summary>
        /// <param name="filter">Filter</param>
        /// <param name="orderBy">Order</param>
        /// <param name="includeProperties">Includes</param>
        IQueryable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = "");

        /// <summary>
        /// Searches by ID
        /// </summary>
        /// <param name="ids">IDs</param>
        TEntity GetByIDs(params object[] ids);

        /// <summary>
        /// Executes a raw SQL query
        /// </summary>
        /// <param name="query">SQL query</param>
        /// <param name="parameters">Parameters</param>
        IEnumerable<TEntity> GetWithRawSql(string query, params object[] parameters);

        /// <summary>
        /// Inserts an entity
        /// </summary>
        /// <param name="entity">Entity to insert</param>
        void Insert(TEntity entity);

        /// <summary>
        /// Updates an entity
        /// </summary>
        /// <param name="entityToUpdate">Entity to update</param>
        void Update(TEntity entityToUpdate);
    }
}
