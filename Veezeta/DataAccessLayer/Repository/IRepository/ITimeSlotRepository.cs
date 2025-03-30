using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;


namespace DataAccessLayer.Repository.IRepository
{
    public interface ITimeSlotRepository : IRespository<TimeSlot>
    {
        void Update(TimeSlot obj);
     
    }
}
