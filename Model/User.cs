public class User
{
    [Required] public string PasswordHash { get; set; }
    [Required, MaxLength(255)] public string FullName { get; set; }
    [Required] public Guid UniversityId { get; set; }
    public UserRole Role { get; set; } = UserRole.Member;
    public bool IsBecMember { get; set; } = false;
    public string? NecPosition { get; set; }
    public string? BecPosition { get; set; }
    public UserStatus Status { get; set; } = UserStatus.Pending;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    [ForeignKey("UniversityId")] public University? University { get; set; }
}
