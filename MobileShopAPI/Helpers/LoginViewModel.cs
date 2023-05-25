﻿using System.ComponentModel.DataAnnotations;

namespace MobileShopAPI.Helpers
{
    public class LoginViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; } = null!;
        [Required]
        public string Password { get; set; } = null!;
    }
}
