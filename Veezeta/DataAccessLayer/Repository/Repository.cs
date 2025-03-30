using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Data;
using DataAccessLayer.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace Bulky.DataAccess.Repository
{
    public class Repository<T> : IRespository<T> where T : class
    {
        private readonly ApplicationContextDb _db;
        internal DbSet<T> dbSet;

        public Repository(ApplicationContextDb db)
        {

            _db = db;
            this.dbSet = _db.Set<T>();
            _db.timeSlots.Include(u => u.Doctor).Include(u => u.DoctorId);
        }
        public void Add(T entity)
        {
            dbSet.Add(entity);
        }

        public T Get(Expression<Func<T, bool>> filter, string? properties = null,bool track=false)
        {
            IQueryable<T> query;
            if (track)
            {
             query = dbSet;
            }
            else
            {
                query = dbSet.AsNoTracking();
            }
                query = query.Where(filter);
            if (!string.IsNullOrEmpty(properties))
            {
                foreach (var includeProp in properties
                    .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProp);
                }
            }
            return query?.FirstOrDefault();
        }

        public IEnumerable<T> GetAll(Expression<Func<T, bool>>? filter=null, string ? properties=null)
        {
            IQueryable<T> query = dbSet;
            if(filter!=null)
            {
            query = query.Where(filter);

            }

            if (!string.IsNullOrEmpty(properties))
            {
                foreach(var includeProp in properties
                    .Split(new char[] {','},StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProp);
                }
            }
            return query.ToList();
        }

        public void Remove(T entity)
        {
            dbSet.Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entity)
        {
            dbSet.RemoveRange(entity);
        }
    }
}
