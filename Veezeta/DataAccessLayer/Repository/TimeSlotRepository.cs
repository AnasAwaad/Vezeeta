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
    public class ClinicRepository : Repository<Clinic>, IClinicRepository
    {

        private ApplicationContextDb _db;

        public ClinicRepository(ApplicationContextDb db):base(db)
        {
            _db = db;
        }


        public void Update(Clinic obj)
        {
            _db.clinics.Update(obj);
        }
    }
}
