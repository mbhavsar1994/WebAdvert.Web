using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebAdvert.Web.Models.Accounts
{
    public class Login
    {
        [Required(ErrorMessage ="Email is required.")]
        [EmailAddress]
        [Display(Name ="Email")]
        public String Email { get; set; }

        [Required(ErrorMessage ="Password is required")]
        [DataType(DataType.Password)]
        [Display (Name = "Password")]
        public String Password { get; set; }


        [Display(Name ="Remember Me")]
        public bool RememberMe { get; set; }
    }
}
