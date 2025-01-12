using PingPongManagement.Application.Common.Interfaces;
using PingPongManagement.Domain.Tournaments;

namespace PingPongManagement.Infrastructure.Tournaments.Persistence;

public class TournamentRepository : ITournamentRepository
{
    public Task<IEnumerable<Tournament>> GetAllAsync(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<Tournament> GetAsync(Guid id, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task AddAsync(Tournament tournament, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
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