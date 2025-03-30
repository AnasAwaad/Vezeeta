using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository.IRepository
{
    public interface IUnitOfWork
    {
       
        public IClinicRepository Clinic { get; }


        public IDoctorRepository Doctor { get;  }
        public ITimeSlotRepository TimeSlot { get;  }
        void Save();
    }
}
