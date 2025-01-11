using PingPongManagement.Domain.Admins;

namespace PingPongManagement.Domain.Sets;

public class Set
{
    public Guid Id { get; private set; }
    public int SetNumber { get; private set; }
    public Guid MatchId { get; private set; }
    public Guid? WinnerId { get; private set; }
    public int Player1Score { get; private set; }
    public int Player2Score { get; private set; }
    public Guid Player1Id { get; private set; }
    public Guid Player2Id { get; private set; }
    
    public Set(Guid matchId, int setNumber)
    {
        Id = Guid.NewGuid();
        MatchId = matchId;
        SetNumber = setNumber;
    }

    private Set()
    {
        
    }
    
    public void RecordScores(int player1Score, int player2Score)
    {
        if (player1Score == player2Score)
        {
            throw new InvalidOperationException("Scores cannot be equal. There must be a winner.");
        }

        Player1Score = player1Score;
        Player2Score = player2Score;

        DetermineWinner();
    }
    
    private void DetermineWinner()
    {
        WinnerId = Player1Score > Player2Score ? Player1Id : Player2Id;
    }
    
    public bool _isComplete => WinnerId.HasValue;
    
    public void AssignPlayers(Guid player1Id, Guid player2Id)
    {
        Player1Id = player1Id;
        Player2Id = player2Id;
    }
}