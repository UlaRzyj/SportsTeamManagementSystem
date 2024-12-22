namespace SportsTeamManagementSystem;

public class Player
{
    public string Name;
    public string Position;
    public int Score;
    
    public Player(string name, string position, int score)
    {
        Name = Name;
        Position = position;
        Score = score;
        
        Team.Players.Add(this);
    }
}