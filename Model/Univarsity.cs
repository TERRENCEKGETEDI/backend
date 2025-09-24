public class Univarsity
{
    [Key] [MaxLength(10)] public Guid Id { get; set; } = Guid.NewGuid();
    [Required, MaxLength(255)] public string Name { get; set; }
    [MaxLength(255)] public string? CampusName { get; set; }
    [MaxLength(100)] public string? Province { get; set; }
}
 
