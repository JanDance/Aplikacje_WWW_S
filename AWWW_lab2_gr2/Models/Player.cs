namespace AWWW_lab2_gr2.Models;
using System.Data;

public class Player
{
    public int Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Country { get; set; }
    public DateTime BirthDate { get; set; }
    public ICollection<MatchPlayer> MatchPlayers { get; set; }
    public int PositionId { get; set; }
    public Position Position { get; set; } = null!;
    public int TeamId { get; set; }
    public Team Team { get; set; } = null!;
}