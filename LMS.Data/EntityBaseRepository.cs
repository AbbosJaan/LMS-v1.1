﻿using LMS.Data.Interfaces;
using LMS.Domain.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Linq.Expressions;

namespace LMS.Data
{
    public class EntityBaseRepository<T> : IEntityBaseRepository<T> where T : class, IEntityBase, new()
    {
        private readonly AppDbContext _context;
        public EntityBaseRepository(AppDbContext context)
        {
                _context = context;
        }
        public async Task<T> AddAsync(T entity)
        {
            var a =await _context.Set<T>().AddAsync(entity);   
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<T> AddAsync(T entity, params Expression<Func<T, object>>[] includePrioerties)
        {
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();
            IQueryable<T> result = _context.Set<T>();
            result = includePrioerties.Aggregate(result, (current, includePrioerties) => current.Include(includePrioerties));
            return await result.FirstOrDefaultAsync(x => x.Id == entity.Id);

        }

        public async Task<bool> DeleteAsync(int id)
        {
            var entity = await _context.Set<T>().FindAsync(id);
            if (entity != null)
            {
                _context.Set<T>().Remove(entity);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            var result = await _context.Set<T>().ToListAsync();
            return result;
        }

        public async Task<IEnumerable<T>> GetAllAsync(params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = _context.Set<T>();
            query = includeProperties.Aggregate(query, (current, includeProperties) => current.Include(includeProperties));
            return await query.ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id) => await _context.Set<T>().FirstOrDefaultAsync(x => x.Id == id);

        public async Task UpdateAsync(int id, T entity)
        { 
            EntityEntry entityEntry = _context.Entry<T>(entity);
            entityEntry.State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
