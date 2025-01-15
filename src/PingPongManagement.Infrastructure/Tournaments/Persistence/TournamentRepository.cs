using PingPongManagement.Application.Common.Interfaces;
using PingPongManagement.Domain.Tournaments;
using PingPongManagement.Infrastructure.Common;

namespace PingPongManagement.Infrastructure.Tournaments.Persistence;

internal class TournamentRepository(PingPongManagementDbContext dbContext) : ITournamentRepository
{
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
        await dbContext.Tournaments.AddAsync(tournament, cancellationToken);
    }

    public Task UpdateAsync(Tournament tournament, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task RemoveAsync(Guid id, CancellationToken cancellationToken)
    {
        var tournament = dbContext.Tournaments.Find(id);
        dbContext.Tournaments.Remove(tournament);
        return Task.CompletedTask;
    }
}