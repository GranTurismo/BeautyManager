using System.ComponentModel.DataAnnotations;

namespace BeautyManager.Shared.Models.Db;

public class BeautyBook
{
    [Key]
    public int Id { get; set; }
    public string CustomerName { get; set; }
    public string CustomerPhone { get; set; }
    public BeautyTask Task { get; set; }
    public DateTimeOffset ExecutingDate { get; set; }
    public DateTimeOffset OrderDate { get; set; }
}