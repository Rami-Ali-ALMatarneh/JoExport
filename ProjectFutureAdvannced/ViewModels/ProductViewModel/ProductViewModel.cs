using ProjectFutureAdvannced.Models.Enums;

namespace ProjectFutureAdvannced.ViewModels.ProductViewModel
    {
    public class ProductViewModel
        {
        public string Name { get; set; }
        public string Description { get; set; }
        public Categorys CategoryName { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }
        }
    }
