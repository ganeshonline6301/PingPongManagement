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
    public string Description { get; }
    public Guid AdminId { get; }

    public Tournament(string title, string description, TournamentType type, Guid adminId, Guid? id = null)
    {
        Type = type;
        Title = title;
        Description = description;
        AdminId = adminId;
        Id = id ?? Guid.NewGuid();
    }

    public ErrorOr<Success> AddMatch(Match match)
    {
        _matchIds.Throw().IfContains(match.Id);

        if (_matchIds.Count == 48)
        {
            return TournamentErrors.CannotIncludeMoreMatchesThanTheTournamentAllows;
        }
        
        _matchIds.Add(match.Id);

        return Result.Success;
    }
    
    public bool HasMatch(Guid gymId)
    {
        return _matchIds.Contains(gymId);
    }
}