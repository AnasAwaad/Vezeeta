using Microsoft.AspNetCore.Identity;

namespace Vezeeta.Entities.Models;
public class ApplicationUser : IdentityUser
{
    public string FullName { get; set; } = null!;
    public bool IsDeleted { get; set; }
    public DateTime CreatedOn { get; set; } = DateTime.Now;
    public DateTime? LastUpdatedOn { get; set; }
}
