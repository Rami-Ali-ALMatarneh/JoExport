using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace ProjectFutureAdvannced.Models.Model.AccountUser
    {
    public class Account:IdentityUser
        {
        [Required]
        [MaxLength(20)]
        public string Name { get; set; }
        public string? ImgUrl { get; set; }
        [MaxLength(20)]
        public string ?Major { get; set; }
        [RegularExpression(@"^(?i)(male|female)$")]
        public string? Gender { get; set; }
        }
    }
