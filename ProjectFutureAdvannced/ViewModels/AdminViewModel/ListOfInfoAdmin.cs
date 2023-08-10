using ProjectFutureAdvannced.Models.Model;

namespace ProjectFutureAdvannced.ViewModels.AdminViewModel
    {
    public class ListOfInfoAdmin
        {
        public IEnumerable<Category> categories { get; set; }
        public GeneralInfoAdmin GeneralInfoAdmin { get; set; }  
        }
    }
