using System.Collections;
using Binabox.Application.Interfaces.Repositories;
using Binabox.Domain.Common;
using Binabox.Persistence.Contexts;

namespace Binabox.Persistence.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private readonly ApplicationDbContext _applicationDbContext;
    private Hashtable _repositories;
    private bool disposed;

    public UnitOfWork(ApplicationDbContext applicationDbContext)
    {
        _applicationDbContext = applicationDbContext ?? throw new ArgumentNullException(nameof(applicationDbContext));
    }

    public IGenericRepository<T> Repository<T>() where T : BaseAuditableEntity
    {
        if (_repositories == null)
            _repositories = new Hashtable();

        var type = typeof(T).Name;

        if (!_repositories.ContainsKey(type))
        {
            var repositoryType = typeof(GenericRepository<>);

            var repositoryInstance = Activator.CreateInstance(repositoryType.MakeGenericType(typeof(T)), _applicationDbContext);

            _repositories.Add(type, repositoryInstance);
        }

        return (IGenericRepository<T>) _repositories[type];
    }

    public Task Rollback()
    {
        _applicationDbContext.ChangeTracker.Entries().ToList().ForEach(x => x.Reload());
        return Task.CompletedTask;
    }

    public async Task<int> Save(CancellationToken cancellationToken)
    {
        return await _applicationDbContext.SaveChangesAsync(cancellationToken);
    }

    public Task<int> SaveAndRemoveCache(CancellationToken cancellationToken, params string[] cacheKeys)
    {
        throw new NotImplementedException();
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (disposed)
        {
            if (disposing)
            {
                //dispose managed resources
                _applicationDbContext.Dispose();
            }
        }
        //dispose unmanaged resources
        disposed = true;
    }
}