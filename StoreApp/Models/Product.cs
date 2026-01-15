using System.ComponentModel.DataAnnotations.Schema;

namespace StoreApp.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public string? Description { get; set; }

        public string? ImageUrl { get; set; }

        // НЕ се записва в базата
        [NotMapped]
        public IFormFile? ImageFile { get; set; }
    }
}
