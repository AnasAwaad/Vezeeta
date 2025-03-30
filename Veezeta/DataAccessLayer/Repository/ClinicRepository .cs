using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Data;
using DataAccessLayer.Repository.IRepository;

using Model;

namespace Bulky.DataAccess.Repository
{
    public class TimeSlotRepository : Repository<TimeSlot>, ITimeSlotRepository
    {

        private ApplicationContextDb _db;

        public TimeSlotRepository(ApplicationContextDb db):base(db)
        {
            _db = db;
        }


        public void Update(TimeSlot obj)
        {
            _db.timeSlots.Update(obj);
        }
    }
}
