using System.ComponentModel.DataAnnotations;

namespace NovaCart_Backend.Models
{
    public class Cart
    {
        [Key] public int CartId { get; set; }

        public User? User { get; set; }
        public ICollection<CartItem>? CartItems { get; set; }

    }
}
