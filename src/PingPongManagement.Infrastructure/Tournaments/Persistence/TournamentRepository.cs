using PingPongManagement.Application.Common.Interfaces;
using PingPongManagement.Domain.Tournaments;
using PingPongManagement.Infrastructure.Common;

namespace PingPongManagement.Infrastructure.Tournaments.Persistence;

internal class TournamentRepository : ITournamentRepository
{
    private readonly PingPongManagementDbContext _dbContext;

    public TournamentRepository(PingPongManagementDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public Task<IEnumerable<Tournament>> GetAllAsync(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<Tournament> GetAsync(Guid id, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public async Task AddAsync(Tournament tournament, CancellationToken cancellationToken)
    {
        await _dbContext.Tournaments.AddAsync(tournament, cancellationToken);
    }

    public Task UpdateAsync(Tournament tournament, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task RemoveAsync(Guid id, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}