using ProjectFutureAdvannced.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace ProjectFutureAdvannced.ViewModels
    {
    public class RegisterShopViewModel:RegisterViewModel
        {
        [Required]
        public Categorys CategoryName { get; set; }
        }
    }
