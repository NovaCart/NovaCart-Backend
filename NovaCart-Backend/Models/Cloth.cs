using System.ComponentModel.DataAnnotations;

namespace NovaCart_Backend.Models
{
    public class Cloth
    {
        [Key] public int ClothId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public string? ImageUrl { get; set; }
        public string? Color { get; set; }
        public string? Size { get; set;}
        public string? Occation { get; set; }

        public ICollection<CartItem>? CartItems { get; set; }
    }
}
