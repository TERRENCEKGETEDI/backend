public class Campus
{
    [Key] public Guid Id { get; set; }
    [Required] public Guid UniversityId { get; set; }
    [MaxLength(10)] public string CampusCode { get; set; }
    [MaxLength(255)] public string Name { get; set; }
    [ForeignKey("UniversityId")] public University University { get; set; }
}
