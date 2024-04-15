using System;

namespace Joker.Models;

public class Player
{
    public Player( string playerName, string position, int weight, int height, DateTime birthday, DateTime gameStart, string team)
    {
        PlayerName = playerName;
        PositionName = position;
        Weight = weight;
        Height = height;
        Birthday = birthday;
        GameStart = gameStart;
        TeamName = team;
    }
    public int PlayerID { get; set; }
    public string PlayerName { get; set; }
    public string PositionName { get; set; }
    public int Position { get; set; }
    public string TeamName { get; set; }
    public decimal Weight { get; set; }
    public decimal Height { get; set; }
    public DateOnly Birthday  { get; set; }
    public DateOnly GameStart  { get; set; }
}