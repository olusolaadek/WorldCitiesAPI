// using Microsoft.Build.Framework;

using System.ComponentModel.DataAnnotations;

namespace WorldCitiesAPI.Data
{
    public class LoginRequest
    {
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }
    }
}
