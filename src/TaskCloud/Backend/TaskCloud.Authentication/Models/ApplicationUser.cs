using Microsoft.AspNetCore.Identity;

using System.ComponentModel.DataAnnotations;

namespace TaskCloud.Authentication.Models
{
    public class ApplicationUser: IdentityUser
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required, RegularExpression(@"(0[1-9]|1[0-2])\/[0-9]{2}",ErrorMessage = "Expiration should match a valid MM/YY value")]
        public string Expiration { get; set; }
        public Role Role { get; set; }
    }
    public enum Role { 
        Admin,
        UserBasic
    }
}
