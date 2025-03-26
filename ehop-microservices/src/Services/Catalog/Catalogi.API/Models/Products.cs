namespace Catalogi.API.Models
{
    public class Products
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;
        public List<string> Category { get; set; } = new();
        public string ImageFile { get; set; }
        public decimal Price { get; set; }
    }
}
