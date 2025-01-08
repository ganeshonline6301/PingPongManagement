using PingPongManagement.Domain.Admins;

namespace PingPongManagement.Application.Common.Interfaces;

public interface IAdminRepository
{
    Task<Admin> GetByIdAsync(Guid id, CancellationToken cancellationToken);
    Task AddAsync(Admin admin, CancellationToken cancellationToken);
    Task UpdateAsync(Admin admin, CancellationToken cancellationToken);
}