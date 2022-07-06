namespace Domain;

public class RefreshToken
{
    public int Id { get; set; }
    public User User { get; set; } = null!;
    public string Token { get; set; } = null!;
    public DateTime Expires { get; set; } = DateTime.UtcNow.AddDays(7);
    
    public bool IsExpired => DateTime.UtcNow >= Expires;
    
    public DateTime? RevokedAt { get; set; }

    public bool IsActive => RevokedAt == null && !IsExpired;
}