using System.ComponentModel.DataAnnotations;

namespace NovaCart_Backend.Models
{
    public class SizeAvailability
    {
        [Key] public int SizeAvailabilityId { get; set; }
        public string? Size {  get; set; }
        public bool? IsAvailable { get; set; }
        public int QuantityStock { get; set;}

        public int ClothId { get; set; }
        public Cloth? Cloth { get; set; }
    }
}
