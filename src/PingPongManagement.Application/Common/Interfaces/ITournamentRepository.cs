using PingPongManagement.Domain.Tournaments;

namespace PingPongManagement.Application.Common.Interfaces;

public interface ITournamentRepository
{
    Task<IEnumerable<Tournament>> GetAllAsync(CancellationToken cancellationToken);
    Task<Tournament> GetAsync(Guid id, CancellationToken cancellationToken);
    Task AddAsync(Tournament tournament, CancellationToken cancellationToken);
    Task UpdateAsync(Tournament tournament, CancellationToken cancellationToken);
    Task RemoveAsync(Guid id, CancellationToken cancellationToken);
}