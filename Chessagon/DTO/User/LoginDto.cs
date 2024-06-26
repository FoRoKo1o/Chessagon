﻿using System.ComponentModel.DataAnnotations;

namespace Chessagon.DTO.User
{
    public class LoginDto
    {
        [Required]
        [StringLength(15, ErrorMessage = "Your Password is limited to {2} to {1} characters", MinimumLength = 6)]
        public string Password { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
