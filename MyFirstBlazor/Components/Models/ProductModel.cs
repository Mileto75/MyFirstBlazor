namespace MyFirstBlazor.Components.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Slug { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public CategoryModel Category { get; set; }
        public IEnumerable<string> Images { get; set; }
    }
}
