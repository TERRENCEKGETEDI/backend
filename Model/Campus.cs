public class Campus
{
    [Key] public Guid CampusId { get; set; }
    [Required] public Guid UnivarsityId { get; set; }
    [MaxLength(10)] public string CampusCode { get; set; }
    [MaxLength(255)] public string Name { get; set; }
    [ForeignKey("UnivarsityId")] public Uniaersity Univarsity { get; set; }
}
