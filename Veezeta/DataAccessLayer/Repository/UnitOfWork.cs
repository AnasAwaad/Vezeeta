using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Data;
using DataAccessLayer.Repository.IRepository;
using Model;

namespace Bulky.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        public ApplicationContextDb _db;


        public IClinicRepository Clinic { get; set; }
        public IDoctorRepository Doctor { get; set; }
        public ITimeSlotRepository TimeSlot { get; set; }

        public UnitOfWork(ApplicationContextDb db)
        {
            _db = db;

            Clinic = new ClinicRepository(_db);
            Doctor=new DoctorRepository(_db);
            TimeSlot=new TimeSlotRepository(_db);

        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
