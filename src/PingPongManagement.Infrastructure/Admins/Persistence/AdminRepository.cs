using PingPongManagement.Application.Common.Interfaces;
using PingPongManagement.Domain.Admins;
using PingPongManagement.Infrastructure.Common;

namespace PingPongManagement.Infrastructure.Admins.Persistence;

internal class AdminRepository : IAdminRepository
{
    private readonly PingPongManagementDbContext _dbContext;

    public AdminRepository(PingPongManagementDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public async Task<Admin> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        return await _dbContext.Admins.FindAsync(id, cancellationToken);
    }

    public async Task AddAsync(Admin admin, CancellationToken cancellationToken)
    {
        await _dbContext.AddAsync(admin, cancellationToken);
        await _dbContext.SaveChangesAsync(cancellationToken);
    }

    public Task UpdateAsync(Admin admin, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(Guid id, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}