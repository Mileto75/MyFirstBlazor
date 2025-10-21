namespace MyFirstBlazor.Services.Models
{
    public class ResultModel<T> : BaseResultModel
    {
        public T Data  { get; set; }
    }
}
