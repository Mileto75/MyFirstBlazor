namespace MyFirstBlazor.Services.Models
{
    public class BaseResultModel
    {
        public bool Ok { get; set; }
        public IEnumerable<string> Errors { get; set; }
    }
}
