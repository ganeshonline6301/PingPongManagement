using ErrorOr;
using PingPongManagement.Domain.Matches;
using Throw;

namespace PingPongManagement.Domain.Tournaments;

public class Tournament
{
    private readonly List<Guid> _matchIds = new();
    private readonly int _maxMatches;
    public Guid Id { get; }
    public string Title { get; }
    public TournamentType Type { get; }
    public TournamentStatus Status { get; }
    public string Description { get; }
    public Guid AdminId { get; }
    
    public IReadOnlyCollection<Guid> Matches => _matchIds.AsReadOnly();

    public Tournament(string title, string description, TournamentType type, Guid adminId, Guid? id = null)
    {
        Type = type;
        Title = title;
        Description = description;
        AdminId = adminId;
        Id = id ?? Guid.NewGuid();
    }

    public ErrorOr<Success> AddMatch(Match match, Guid player1Id, Guid player2Id)
    {
        _matchIds.Throw().IfContains(match.Id);

        if (_matchIds.Count == 48)
        {
            return TournamentErrors.CannotIncludeMoreMatchesThanTheTournamentAllows;
        }

        if (player1Id.Equals(AdminId) || player2Id.Equals(AdminId))
        {
            return TournamentErrors.TournamentOwnerCannotbeParticipate;
        }
        
        _matchIds.Add(match.Id);

        return Result.Success;
    }
    
    public bool HasMatch(Guid gymId)
    {
        return _matchIds.Contains(gymId);
    }
}