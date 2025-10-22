namespace PokerPortfolio.Models;

public class Project
{
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string TechStack { get; set; } = string.Empty;
    public string GitHubUrl { get; set; } = string.Empty;
    public string Icon { get; set; } = string.Empty; // For pixel icons
    public int Order { get; set; } = 0; // Which "card" this appears on
    public string Rank { get; set; } = string.Empty; // Card rank (Q, J, 10, etc.)
    public string Suit { get; set; } = string.Empty; // Card suit (♠, ♣, ♥, ♦)
}
