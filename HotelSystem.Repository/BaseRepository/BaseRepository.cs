using DAL.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace HotelSystem.Repository.BaseRepository
{
    public abstract class BaseRepository<TEntity>: IBaseRepository<TEntity> where TEntity:class
    {
        protected readonly HotelContext _context;

        // ctor
        public BaseRepository(HotelContext context)
        {
            _context = context;
        }

        #region Get Methods
        public TEntity Find(int id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        public ICollection<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return _context.Set<TEntity>().Where(predicate).ToList();
        }

        public ICollection<TType> Get<TType>(Expression<Func<TEntity, bool>> where, Expression<Func<TEntity, TType>> select) where TType : class
        {
            return _context.Set<TEntity>().Where(where).Select(select).ToList();
        }

        public ICollection<TType> Get<TType>(Expression<Func<TEntity, TType>> select) where TType : class
        {
            return _context.Set<TEntity>().Select(select).ToList();
        }

        public ICollection<TEntity> GetAll()
        {
            return _context.Set<TEntity>().ToList();
        }

        public TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate)
        {
            return _context.Set<TEntity>().SingleOrDefault(predicate);
        }
        #endregion

        #region Update Methods
        public void Update(TEntity entity)
        {
            _context.Set<TEntity>().Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }

        public void Update(ICollection<TEntity> entities)
        {
            foreach (var entity in entities)
            {
                Update(entity);
            }
        }
        #endregion

        #region Add Methods
        public void Add(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
        }
        #endregion

        #region Delete Methods
        public void Delete(int id)
        {
            TEntity ent = _context.Set<TEntity>().Find(id);
            _context.Set<TEntity>().Remove(ent);
        }

        public void Delete(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
        }
        #endregion
    }
}
