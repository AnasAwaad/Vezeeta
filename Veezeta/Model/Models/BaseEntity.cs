namespace Vezeeta.Entities.Models;
public class BaseEntity
{
	public bool IsDeleted { get; set; }
	public DateTime CreatedOn { get; set; } = DateTime.Now;
	public DateTime? LastUpdatedOn { get; set; }

	public string CeatedById { get; set; } = null!;
	public ApplicationUser CreatedBy { get; set; } = null!;

	public string? LastUpdatedById { get; set; }
	public ApplicationUser? UpdatedBy { get; set; }
}
