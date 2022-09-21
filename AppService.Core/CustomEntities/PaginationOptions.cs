namespace AppService.Core.CustomEntities
{
    public class PaginationOptions
    {
        public int DefaultPageSize { get; set; }
        public int DefaultPageNumber { get; set; }
        public string FolderDocumentation { get; set; }
        public string UrlGetFiles { get; set; }
        public string UserSap { get; set; }

        public string PasswordSap { get; set; }
        
    }
}
