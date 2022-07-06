using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MobileZone.Models.ViewModel
{
    public class UserViewModels
    {
        public class LoginModel
        {
            [Required]
            [UIHint("name")]
            public string Name { get; set; }

            [Required]
            [UIHint("password")]
            public string Password { get; set; }

            public string ReturnUrl { get; set; } = "/";
        }

        public class RegisterModel
        {
            [Required]
            [Display(Name = "User name")]
            public string UserName { get; set; }

            [Required]
            [Display(Name = "E-mail")]
            [EmailAddress]
            public string Email { get; set; }

            [Required]
            [DataType(DataType.Password)]
            public string Password { get; set; }

            [Compare("Password", ErrorMessage = "Passwords must match")]
            [Display(Name = "Confirm Password")]
            [DataType(DataType.Password)]
            public string ConfirmPassword { get; set; }
        }

    }
}
