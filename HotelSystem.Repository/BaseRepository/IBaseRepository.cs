using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace HotelSystem.Repository.BaseRepository
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        #region Retrieve
        TEntity Find(int id);
        ICollection<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
        ICollection<TType> Get<TType>(Expression<Func<TEntity, bool>> where, Expression<Func<TEntity, TType>> select) where TType : class;
        ICollection<TType> Get<TType>(Expression<Func<TEntity, TType>> select) where TType : class;
        ICollection<TEntity> GetAll();
        TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate);
        #endregion

        #region Create
        void Add(TEntity entity);
        #endregion

        #region Update
        void Update(TEntity entity);
        void Update(ICollection<TEntity> entities);
        #endregion

        #region Delete
        void Delete(int id);
        void Delete(TEntity entity); 
        #endregion
    }
}
