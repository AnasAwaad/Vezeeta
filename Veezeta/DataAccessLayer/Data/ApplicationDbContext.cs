using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Vezeeta.Entities.Models;

namespace Vezeeta.DAL.Data
{
	public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
		: base(options) { }
		public DbSet<Clinic> Clinics { get; set; }
		public DbSet<Doctor> Doctors { get; set; }
		public DbSet<TimeSlot> TimeSlots { get; set; }

		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);

			builder.Entity<Doctor>()
				.HasOne(a => a.User)
				.WithOne(d => d.DoctorProfile)
				.HasForeignKey<Doctor>(a => a.UserId)
				.OnDelete(DeleteBehavior.Restrict);

			builder.Entity<Doctor>()
				.HasOne(d => d.CreatedBy)
				.WithMany()
				.HasForeignKey(d => d.CeatedById)
				.OnDelete(DeleteBehavior.Restrict);
		}

	}
}
