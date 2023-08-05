using ProjectFutureAdvannced.Models.Model;

namespace ProjectFutureAdvannced.Models.IRepository
{
    public interface IShopRepository
        {
        public Shop Add(Shop shop);
        public Shop Delete( string id);
        public Shop Get(string id);
        public IEnumerable<Shop> GetAll();
        public Shop Update( Shop shop );
        }
    }
