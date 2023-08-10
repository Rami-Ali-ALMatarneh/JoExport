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
        public string UrlImgString { get;set; }
        }
}
