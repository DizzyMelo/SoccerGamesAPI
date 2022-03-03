using Microsoft.EntityFrameworkCore;
using SoccerGame.Core.Repositories.Base;
using SoccerGame.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerGame.Infrastructure.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly TeamContext _teamContext;
        public Repository(TeamContext teamContext)
        {
            _teamContext = teamContext;
        }
        public async Task<T> AddAsync(T entity)
        {
            await _teamContext.Set<T>().AddAsync(entity);
            await _teamContext.SaveChangesAsync();
            return entity;
        }
        public async Task DeleteAsync(T entity)
        {
            _teamContext.Set<T>().Remove(entity);
            await _teamContext.SaveChangesAsync();
        }
        public async Task<IReadOnlyList<T>> GetAllAsync()
        {
            return await _teamContext.Set<T>().ToListAsync();
        }
        public async Task<T> GetByIdAsync(int id)
        {
            return await _teamContext.Set<T>().FindAsync(id);
        }
        public Task UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
