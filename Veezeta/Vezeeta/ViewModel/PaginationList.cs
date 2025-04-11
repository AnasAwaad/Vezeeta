namespace Vezeeta.Presentation.ViewModel;
public class PaginatedList<T>
{
	public IEnumerable<T> Items { get; private set; }
	public int PageIndex { get; private set; }
	public int TotalPages { get; private set; }
	public int TotalCount { get; private set; }

	public bool HasPreviousPage => PageIndex > 1;
	public bool HasNextPage => PageIndex < TotalPages;

	public PaginatedList(IEnumerable<T> items, int count, int pageIndex, int pageSize)
	{
		Items = items;
		TotalCount = count;
		PageIndex = pageIndex;
		TotalPages = (int)Math.Ceiling(count / (double)pageSize);
	}

	public static PaginatedList<T> Create(IQueryable<T> source, int pageIndex, int pageSize)
	{
		var count = source.Count();
		var items = source.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
		return new PaginatedList<T>(items, count, pageIndex, pageSize);
	}
}
