using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskEvaluation.Core.Interfaces.IRepositories;

namespace TaskEvaluation.Infrastructure.Repositoies
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly DbContext _dbContext;
        private readonly DbSet<T> _dbSet;

        public BaseRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = dbContext.Set<T>();
        }
        public async Task<T> CreateAsync(T model)
        {
            await _dbSet.AddAsync(model);
            await _dbContext.SaveChangesAsync();
            return model;
        }

        public async Task CreateRange(List<T> model)
        {
            await _dbSet.AddRangeAsync(model);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(T model)
        {
            _dbSet.Remove(model);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<T> GetByIdAsync<Tid>(Tid id)
        {

            return await _dbSet.FindAsync(id);
        }

        public async Task SaveChangeAsync()
        {
            await _dbContext.SaveChangesAsync();
        }

        public async Task<T> UpdateAsync(T model)
        {
            _dbContext.Entry(model).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
            return model;
        }
    }
}
