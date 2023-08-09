﻿using Microsoft.AspNetCore.Identity;
using ProjectFutureAdvannced.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectFutureAdvannced.Models.Model.AccountUser
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [Compare("Password", ErrorMessage = "Confirm Password & Password is not Match!")]
        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }


        [Required]
        public TypeOfUser TypeOfRoles { get; set; }


        [ForeignKey("IdentityUser")]
        public string UserId { get; set; }
        public IdentityUser IdentityUser { get; set; }
    }
}