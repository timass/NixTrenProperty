﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace NixTrenProperty.ViewModels
{
    public class LoginViewModel
    {
            [Required]
            [Display(Name = "User name")]
            public string UserName { get; set; }

            [Required]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

            [Display(Name = "Save this information for next time?")]
            public bool RememberMe { get; set; }
            public string ReturnUrl { get; set; }        
    }
}

