using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace ProjectFutureAdvannced.Models.Model.AccountUser
    {
    public class Account:IdentityUser
        {
        [Required]
        [MaxLength(20)]
        public string Name { get; set; }
        }
    }
