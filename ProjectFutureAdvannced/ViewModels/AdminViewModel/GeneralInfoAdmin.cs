using ProjectFutureAdvannced.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace ProjectFutureAdvannced.ViewModels.AdminViewModel
{
    public class GeneralInfoAdmin
        {
        [Required]
        [MaxLength(20)]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public TypeOfUser TypeOfRoles { get; set; }
        public IFormFile ImgUser { get; set; } 
        public string UrlImgString { get; set; } = string.Empty;
        [RegularExpression(@"(77|79|78)\d{7}")] 
        public string PhoneNumber { get; set; } = string.Empty;
        public DateTime? Birthday { get; set; } = DateTime.Now;
        [RegularExpression(@"^(?i)(male|female)$")] 
        public string Gender { get; set; } = string.Empty;
        }
}
