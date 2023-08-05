using Microsoft.AspNetCore.Identity;
using ProjectFutureAdvannced.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace ProjectFutureAdvannced.Models.Model
    {
    public class Shop
        {
        public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        public string ShopName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public string? imgShop { get; set; } 
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

        public Categorys CategorysType { get; set; } 
        public Category category { get; set; }
        public List<Product> products { get; set; }
        }
    }
