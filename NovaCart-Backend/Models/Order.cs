using System.ComponentModel.DataAnnotations;

namespace NovaCart_Backend.Models
{
    public class Order
    {
        [Key] public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal SubTotal { get; set; }
        public decimal ShippingFee { get; set; }

        public User? User { get; set; }
    }
}
