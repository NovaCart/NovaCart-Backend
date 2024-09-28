using System.ComponentModel.DataAnnotations;

namespace NovaCart_Backend.Models
{
    public class User
    {
        [Key] public int UserId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Password { get; set;}
        public string? PhoneNumber { get; set;}
        public string? ProfileImageUrl { get; set; }
        public string? Address { get; set; }

        public int CartId { get; set; }
        public Cart? Cart { get; set; }   //one to one relationship with cart
        public ICollection<Order>? Orders { get; set; }     //one to many
    }
    
    
}
