namespace AppService.Core.DTOs
{
    public class AppProductVariableSearchTextDto
    {

        public int Id { get; set; }
        public int? AppProductId { get; set; }
        public int? AppVariableId { get; set; }
        public string CodeVariable { get; set; }
        public string SearchText { get; set; }





    }
}
