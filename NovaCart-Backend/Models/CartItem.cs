using System.ComponentModel.DataAnnotations;

namespace NovaCart_Backend.Models
{
    public class CartItem
    {
        [Key] public int CaryItemId { get; set; }
        public int Quantity { get; set; }

        public Cloth? Cloth { get; set; }
    }
}
