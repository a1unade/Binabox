using Binabox.Application.Interfaces.Repositories;
using Binabox.Domain.Common;
using Binabox.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Binabox.Persistence.Repositories;

public class GenericRepository<T> : IGenericRepository<T> where T : BaseAuditableEntity
{
    private readonly ApplicationDbContext _applicationDbContext;

    public GenericRepository(ApplicationDbContext applicationDbContext)
    {
        _applicationDbContext = applicationDbContext;
    }

    public IQueryable<T> Entities => _applicationDbContext.Set<T>();

    public async Task<T> AddAsync(T entity)
    {
        await _applicationDbContext.Set<T>().AddAsync(entity);
        return entity;
    }

    public Task UpdateAsync(T entity)
    {
        T exist = _applicationDbContext.Set<T>().Find(entity.Id);
        _applicationDbContext.Entry(exist).CurrentValues.SetValues(entity);
        return Task.CompletedTask;
    }

    public Task DeleteAsync(T entity)
    {
        _applicationDbContext.Set<T>().Remove(entity);
        return Task.CompletedTask;
    }

    public async Task<List<T>> GetAllAsync()
    {
        return await _applicationDbContext
            .Set<T>()
            .ToListAsync();
    }

    public async Task<T> GetByIdAsync(int id)
    {
        return await _applicationDbContext.Set<T>().FindAsync(id);
    }
}