using Vezeeta.Entities.Models;

namespace Vezeeta.Entities.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {

        public IRespository<Clinic> Clinics { get; }


        public IRespository<Doctor> Doctors { get; }
        public IRespository<TimeSlot> TimeSlots { get; }
        void Save();
    }
}
