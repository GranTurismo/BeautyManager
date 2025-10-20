using System.ComponentModel.DataAnnotations;

namespace BeautyManager.Shared.Models.Db;

public class BeautyTaskStylist
{
    [Key]
    public int Id { get; set; }
    public BeautyTask BeautyTask { get; set; }
    public Stylist Stylist { get; set; }
    public int StylistId { get; set; }
    public int BeautyTaskId { get; set; }
}