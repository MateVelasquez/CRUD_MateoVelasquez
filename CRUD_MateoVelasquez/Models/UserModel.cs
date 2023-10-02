using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Xml.Linq;

namespace CRUD_MateoVelasquez.Models
{
    public class UserModel
    {
        [Required]
        public int ID { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Email { get; set; }
        [Required]
        public string? Country { get; set; }
        [Required]
        public string? City { get; set; }
        [Required]
        [DefaultValue(1234567890)]
        [StringLength(10)]
        public string? Phone { get; set; }
        [Required]
        public string? Address { get; set; }
        [Required]
        public string? PostalCode { get; set; }
        [Required]
        public string? Postal { get; set; }
    }
    
}
