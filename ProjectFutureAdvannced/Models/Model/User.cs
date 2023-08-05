using Microsoft.AspNetCore.Identity;
using ProjectFutureAdvannced.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace ProjectFutureAdvannced.Models.Model
    {
    public class User 
        {
        public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        public string AdminName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [Compare("Password", ErrorMessage = "Confirm Password & Password is not Match!")]
        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }
        [Required]
        public TypeOfUser TypeOfUser { get; set; }
        [Required]
        [StringLength(10)]
        [RegularExpression(@"(77|79|78)\d{7}")]
        public string phone { get; set; }
        



        }
    }
