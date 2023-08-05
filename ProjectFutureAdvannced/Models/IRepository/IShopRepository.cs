using ProjectFutureAdvannced.Models.Model;

namespace ProjectFutureAdvannced.Models.IRepository
{
    public interface IShopRepository
        {
        public Shop Add(Shop shop);
        public Shop Delete( int id);
        public Shop Get(int id);
        public IEnumerable<Shop> GetAll();
        public Shop Update( Shop shop );
        }
    }
