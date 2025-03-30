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
    public class DoctorRepository : Repository<Doctor>, IDoctorRepository
    {

        private ApplicationContextDb _db;

        public DoctorRepository(ApplicationContextDb db):base(db)
        {
            _db = db;
        }


        public void Update(Doctor obj)
        {
            _db.doctors.Update(obj);
        }
    }
}
