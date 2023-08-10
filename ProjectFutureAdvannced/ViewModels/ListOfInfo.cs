using ProjectFutureAdvannced.Models.Model;
using ProjectFutureAdvannced.Models.Model.AccountUser;
using ProjectFutureAdvannced.ViewModels.AdminViewModel;

namespace ProjectFutureAdvannced.ViewModels
{
    public class ListOfInfo
        {
        public IEnumerable<Category> categories { get; set; }
        public IEnumerable<Product> products { get; set; }
        public IEnumerable<Shop> shops { get; set; }
        }
    }
