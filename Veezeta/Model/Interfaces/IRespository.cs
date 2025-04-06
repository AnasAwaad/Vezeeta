using System.Linq.Expressions;

namespace Vezeeta.Entities.Interfaces
{
	public interface IRespository<T> where T : class
	{
		IEnumerable<T> GetAll(Expression<Func<T, bool>>? filter = null, string? properties = null, bool track = true);
		T Get(Expression<Func<T, bool>> filter, string? properties = null, bool track = true);
		T? GetById(int id);
		void Add(T entity);
		void Update(T entity);

		void Remove(T entity);

		void RemoveRange(IEnumerable<T> entity);
	}
}
