using PingPongManagement.Application.Common.Interfaces;
using PingPongManagement.Domain.Matches;

namespace PingPongManagement.Infrastructure.Matches.Persistence;

public class MatchRepository : IMatchRepository
{
    public Task<IEnumerable<Match>> GetAllAsync(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<Match> GetAsync(Guid id, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task AddAsync(Match match, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(Match match, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task RemoveAsync(Guid id, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}