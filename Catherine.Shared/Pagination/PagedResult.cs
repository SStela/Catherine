using System.Collections.Generic;

namespace Catherine.Shared.Pagination
{
    public class PagedResult<T>
    {
        public int Count { get; set; }
        public int TotalCount { get; set; }

        public IEnumerable<T> Data { get; set; }
    }
}