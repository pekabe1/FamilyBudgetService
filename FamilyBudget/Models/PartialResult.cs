using Microsoft.EntityFrameworkCore;

namespace DataAccess.Models
{
    public class PartialResult<T> : List<T>
    {
        public PartialResult(IEnumerable<T> items, int page, int pageSize, int totalCount)
        {
            Page = page;
            PageSize = pageSize;
            TotalCount = totalCount;
            AddRange(items);
        }

        public int Page { get; }
        public int PageSize { get; }
        public int TotalCount { get; }

        public static async Task<PartialResult<T>> CreateAsync(IQueryable<T> query,
            int page,
            int pageSize,
            CancellationToken cancellationToken = default)
        {
            var count = await query.CountAsync(cancellationToken);
            var items = await query
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync(cancellationToken);

            return new PartialResult<T>(items, page, pageSize, count);

        }
    }
}
