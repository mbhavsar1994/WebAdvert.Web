﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAdvert.Web.Models.Accounts
{
    public class ConfirmModel
    {
        [Required(ErrorMessage = "Email Address is required")]
        [Display(Name = "Email")]
        [EmailAddress]
        public String Email { get; set; }

        [Required(ErrorMessage = "Code is required")]
        public String Code { get; set; }
    }
}
