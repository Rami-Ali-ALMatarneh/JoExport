using Microsoft.Build.Framework;

namespace ProjectFutureAdvannced.ViewModels.CategoryViewModel
    {
    public class CreateCategoryViewModel
        {
        [Required]
        public string Name { get; set; }
        [Required]
        public IFormFile ImageFile { get; set; }
        }
    }
