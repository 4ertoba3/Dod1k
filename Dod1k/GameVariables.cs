// GameVariables.cs
public class GameVariables
{
    public int Speed { get; set; } = 10;
    public int Gravity { get; set; } = 10;
    public int Score { get; set; } = 0;
    public int CoinCount { get; set; } = 0;
    public int SpeedCount { get; set; } = 0;
    public int GhostCount { get; set; } = 0;
    public int RecordCount { get; set; } = 0;
    public int HighScore { get; set; } = 0;
    public bool SB { get; set; } = false; // Speed Boost
    public bool GB { get; set; } = false; // Ghost Boost
    public bool Burger { get; set; } = false;

    public GameVariables()
    {
    }
    public void Reset()
    {
        Score = 0;
        Speed = 10;
        Gravity = 10;
        SB = false;
        GB = false;
        Burger = false;
    }

}
