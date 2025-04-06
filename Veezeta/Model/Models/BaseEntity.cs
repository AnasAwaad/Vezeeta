namespace Vezeeta.Entities.Models;
public class BaseEntity
{
    public bool IsDeleted { get; set; }
    public DateTime CreatedOn { get; set; } = DateTime.Now;
    public DateTime? LastUpdatedOn { get; set; }
}
