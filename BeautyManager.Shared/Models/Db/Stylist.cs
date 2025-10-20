using System.ComponentModel.DataAnnotations;

namespace BeautyManager.Shared.Models.Db;

public class Stylist
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public ICollection<BeautyBook> Books { get; set; }
    public ICollection<BeautyTaskStylist> BeautyTaskStylists { get; set; }
}