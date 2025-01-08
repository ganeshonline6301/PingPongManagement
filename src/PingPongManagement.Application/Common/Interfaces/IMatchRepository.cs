using PingPongManagement.Domain.Matches;

namespace PingPongManagement.Application.Common.Interfaces;

public interface IMatchRepository
{
    Task<IEnumerable<Match>> GetAllAsync(CancellationToken cancellationToken);
    Task<Match> GetAsync(Guid id, CancellationToken cancellationToken);
    Task AddAsync(Match match, CancellationToken cancellationToken);
    Task UpdateAsync(Match match, CancellationToken cancellationToken);
    Task RemoveAsync(Guid id, CancellationToken cancellationToken);
}