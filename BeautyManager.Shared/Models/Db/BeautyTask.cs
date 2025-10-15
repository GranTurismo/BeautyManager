using System.ComponentModel.DataAnnotations;

namespace BeautyManager.Shared.Models.Db;

public class BeautyTask
{
    [Key]
    public int Id { get; set; }
    public required string TaskTitle { get; set; }
    public required TimeOnly TaskDuration { get; set; }
}