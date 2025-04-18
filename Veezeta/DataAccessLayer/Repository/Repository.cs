﻿using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using Vezeeta.DAL.Data;
using Vezeeta.Entities.Interfaces;

namespace Vezeeta.DAL.Repository
{
	public class Repository<T> : IRespository<T> where T : class
	{
		private readonly ApplicationDbContext _db;
		private readonly DbSet<T> _dbSet;

		public Repository(ApplicationDbContext db)
		{

			_db = db;
			_dbSet = _db.Set<T>();
			_db.TimeSlots.Include(u => u.Doctor).Include(u => u.DoctorId);
		}
		public void Add(T entity)
		{
			_dbSet.Add(entity);
		}

		public T Get(Expression<Func<T, bool>> filter, string? properties = null, bool track = true)
		{
			IQueryable<T> query = _dbSet;
			if (!track)
				query = _dbSet.AsNoTracking();

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

		public IEnumerable<T> GetAll(Expression<Func<T, bool>>? filter = null, string? properties = null, bool track = true, int? pageNumber = null, int? pageSize = null)
		{
			IQueryable<T> query = _dbSet;

			if (!track)
				query = query.AsNoTracking();

			if (filter != null)
			{
				query = query.Where(filter);

			}

			if (!string.IsNullOrEmpty(properties))
			{
				foreach (var includeProp in properties
					.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
				{
					query = query.Include(includeProp);
				}
			}

			if (pageNumber is not null && pageSize is not null)
			{
				query = query.Skip((pageNumber.Value - 1) * pageSize.Value).Take(pageSize.Value);
			}



			return query.ToList();
		}

		public T? GetById(int id)
		{
			return _dbSet.Find(id);
		}

		public void Remove(T entity)
		{
			_dbSet.Remove(entity);
		}

		public void RemoveRange(IEnumerable<T> entity)
		{
			_dbSet.RemoveRange(entity);
		}

		public void Update(T entity)
		{
			_dbSet.Update(entity);
		}

		public int CountAll(Expression<Func<T, bool>>? filter = null)
		{
			IQueryable<T> query = _dbSet;

			if (filter is not null)
				query = _dbSet.Where(filter);

			return _dbSet.Count();
		}
	}
}
