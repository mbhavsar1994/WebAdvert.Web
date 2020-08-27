using System;
using System.ComponentModel.DataAnnotations;


namespace WebAdvert.Web.Models.Accounts
{
    public class SignupModel
    {
        [Required]
        [EmailAddress]
        [Display(Name ="Email")]
        public String Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(6,ErrorMessage ="Password must be at least six characaters long!")]
        [Display(Name ="Password")]
        public String Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage ="Password and it's confirmation do not match")]
        public String ConfirmPassword { get; set; }
    }
}
