using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Model;

namespace DataAccessLayer.Data
{
    public class ApplicationContextDb : DbContext
    {
        public ApplicationContextDb(DbContextOptions<ApplicationContextDb> options)
        : base(options) { }
        public DbSet<Clinic> clinics { get; set; }
        public DbSet<Doctor> doctors { get; set; }
        public DbSet<TimeSlot> timeSlots { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Clinic>().HasData(new Clinic { Id = 1, Name = "Sunrise Health Clinic", Location = "New York, NY" },
                new Clinic { Id = 2, Name = "Greenwood Family Clinic", Location = "Los Angeles, CA" },
                new Clinic { Id = 3, Name = "Wellness Care Center", Location = "Chicago, IL" },
                new Clinic { Id = 4, Name = "Downtown Medical", Location = "Houston, TX" },
                new Clinic { Id = 5, Name = "CarePlus Clinic", Location = "Phoenix, AZ" },
                new Clinic { Id = 6, Name = "Healthy Life Clinic", Location = "Philadelphia, PA" },
                new Clinic { Id = 7, Name = "Pine Tree Health", Location = "San Antonio, TX" },
                new Clinic { Id = 8, Name = "Evergreen Medical", Location = "San Diego, CA" },
                new Clinic { Id = 9, Name = "Community Care Center", Location = "Dallas, TX" },
                new Clinic { Id = 10, Name = "Healing Hands Clinic", Location = "San Jose, CA" },
                new Clinic { Id = 11, Name = "Maple Leaf Clinic", Location = "Austin, TX" },
                new Clinic { Id = 12, Name = "Sunflower Family Practice", Location = "Jacksonville, FL" },
                new Clinic { Id = 13, Name = "Oakwood Health Services", Location = "San Francisco, CA" },
                new Clinic { Id = 14, Name = "Blue Ridge Medical", Location = "Columbus, OH" },
                new Clinic { Id = 15, Name = "Riverfront Healthcare", Location = "Fort Worth, TX" },
                new Clinic { Id = 16, Name = "Hopewell Medical Center", Location = "Charlotte, NC" },
                new Clinic { Id = 17, Name = "Summit Medical Group", Location = "Indianapolis, IN" },
                new Clinic { Id = 18, Name = "Horizon Health", Location = "Seattle, WA" },
                new Clinic { Id = 19, Name = "Willow Creek Clinic", Location = "Denver, CO" },
                new Clinic { Id = 20, Name = "Silver Lake Health", Location = "Boston, MA" });
            var timeSlots = Enumerable.Range(1, 40).Select(i => new TimeSlot
            {
                Id = i,
                Date = $"2025-03-{((i - 1) % 31) + 1:D2}", 
                Avaiable = true,
                DoctorId = ((i - 1) % 20) + 1 
            }).ToArray();

            modelBuilder.Entity<TimeSlot>().HasData(timeSlots);

            
            var timeSlotGroups = timeSlots
                .GroupBy(ts => ts.DoctorId)
                .ToDictionary(g => g.Key, g => string.Join(",", g.Select(ts => ts.Id)));

            modelBuilder.Entity<Doctor>().HasData(
                Enumerable.Range(1, 20).Select(i => new Doctor
                {
                    Id = i,
                    Name = $"Dr. {GetRandomName()}",
                    Description = $"Expert in {GetSpecialization(i)}.\nProvides top-notch care.",
                    Specailized = GetSpecialization(i),
                    Price = GetPrice(i),
                    ImageUrl = "",
                    SelectedTimeSlots = timeSlotGroups.ContainsKey(i) ? timeSlotGroups[i] : ""
                }).ToArray()
            );


            base.OnModelCreating(modelBuilder);
        }
        private static string GetRandomName()
        {
            string[] names = { "John Smith", "Emily Johnson", "Michael Brown", "Sarah Davis", "David Wilson",
                       "Linda Martinez", "Robert Anderson", "Patricia Thomas", "James Jackson", "Barbara White",
                       "Richard Harris", "Susan Clark", "Daniel Lewis", "Nancy Walker", "Thomas Hall",
                       "Karen Allen", "Steven Young", "Donna King", "Paul Wright", "Jennifer Scott" };
            return names[Random.Shared.Next(names.Length)];
        }

        private static string GetSpecialization(int id)
        {
            string[] specializations = { "Cardiology", "Dermatology", "Neurology", "Pediatrics", "Orthopedics",
                                 "Gynecology", "General Medicine", "ENT", "Urology", "Gastroenterology",
                                 "Oncology", "Psychiatry", "Nephrology", "Endocrinology", "Radiology",
                                 "Rheumatology", "Plastic Surgery", "Pulmonology", "Hematology", "Ophthalmology" };
            return specializations[(id - 1) % specializations.Length];
        }

        private static double GetPrice(int id)
        {
            double[] prices = { 150, 120, 180, 110, 200, 130, 100, 140, 160, 170, 220, 130, 190, 140, 180, 160, 250, 170, 200, 150 };
            return prices[(id - 1) % prices.Length];
        }
    }
}
