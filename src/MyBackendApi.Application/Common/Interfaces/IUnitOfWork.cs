using MyBackendApi.Domain.Common;
using MyBackendApi.Domain.Interfaces.Repositories;

namespace MyBackendApi.Application.Common.Interfaces;

public interface IUnitOfWork : IDisposable
{
    IGenericRepository<T> Repository<T>() where T : BaseEntity;
    Task<int> CompleteAsync(CancellationToken cancellationToken = default);
}
