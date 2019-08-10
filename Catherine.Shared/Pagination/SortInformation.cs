using System.ComponentModel;

namespace Catherine.Shared.Pagination
{
    public class SortInformation
    {
        public string PropertyName { get; set; }

        public ListSortDirection SortDirection { get; set; }
    }
}