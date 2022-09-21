namespace AppService.Core.CustomEntities
{
    public class Metadata
    {
        public bool IsValid { get; set; }

        public string Message { get; set; }

        public int TotalCount { get; set; }

        public int PageSize { get; set; }

        public int CurrentPage { get; set; }

        public int TotalPage { get; set; }

        public bool HasNextPage { get; set; }

        public bool HasPreviousPage { get; set; }

        public string NextPageUrl { get; set; }

        public string PreviousPageUrl { get; set; }
        public bool success { get; set; }

    }
}
