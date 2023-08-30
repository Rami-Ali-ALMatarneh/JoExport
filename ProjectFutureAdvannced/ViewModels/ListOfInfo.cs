using ProjectFutureAdvannced.Models.Enums;
using ProjectFutureAdvannced.Models.Model;
using ProjectFutureAdvannced.Models.Model.AccountUser;
using ProjectFutureAdvannced.ViewModels.AdminViewModel;
using ProjectFutureAdvannced.ViewModels.UserViewModel;

namespace ProjectFutureAdvannced.ViewModels
{
    public class ListOfInfo
        {
        public IEnumerable<Category> categories { get; set; }
        public IEnumerable<Product> products { get; set; }
        public IEnumerable<Card> cards { get; set; }
        public IEnumerable<Shop> shops { get; set; }
        public Account carrentUser { get; set; }
        public GeneralInfoUser generalInfoUser { get; set; }
        public Categorys categorys { get; set; }
        }
    }
