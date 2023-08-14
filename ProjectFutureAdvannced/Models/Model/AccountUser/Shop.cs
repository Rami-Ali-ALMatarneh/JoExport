using Microsoft.AspNetCore.Identity;
using ProjectFutureAdvannced.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectFutureAdvannced.Models.Model.AccountUser
{
    public class Shop
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
        public Account IdentityUser { get; set; }
        public Categorys ?CategoryName { get; set; }
        public Category Category { get; set; }
        public List<Product> Products { get; set; }
        public string? ImgUrl { get; set; }
        [RegularExpression(@"(77|79|78)\d{7}")]
        public string? PhoneNumber { get; set; }
        public DateTime? Birthday { get; set; }
        [RegularExpression(@"^(?i)(male|female)$")]
        public string? Gender { get; set; }
        }
    }
