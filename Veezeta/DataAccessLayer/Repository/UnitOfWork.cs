using Vezeeta.DAL.Data;
using Vezeeta.DAL.Repository;
using Vezeeta.Entities.Interfaces;
using Vezeeta.Entities.Models;

namespace Bulky.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        public ApplicationDbContext _db;


        public IRespository<Clinic> Clinics { get; set; }
        public IRespository<Doctor> Doctors { get; set; }
        public IRespository<TimeSlot> TimeSlots { get; set; }


        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;

            Clinics = new Repository<Clinic>(_db);
            Doctors = new Repository<Doctor>(_db);
            TimeSlots = new Repository<TimeSlot>(_db);

        }

        public void Save()
        {
            _db.SaveChanges();
        }

        public void Dispose()
        {
            _db.Dispose();
        }
    }

}
