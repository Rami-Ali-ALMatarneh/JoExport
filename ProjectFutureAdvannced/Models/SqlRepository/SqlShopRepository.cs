using Microsoft.EntityFrameworkCore;
using ProjectFutureAdvannced.Data;
using ProjectFutureAdvannced.Models.IRepository;
using ProjectFutureAdvannced.Models.Model;

namespace ProjectFutureAdvannced.Models.SqlRepository
    {
    public class SqlShopRepository : IShopRepository
        {
        private readonly AppDbContext appDbContext;
        public SqlShopRepository( AppDbContext appDbContext )
            {
            this.appDbContext = appDbContext;
            }
        public Shop Add( Shop shop )
            {
            appDbContext.shop.Add(shop);
            appDbContext.SaveChanges();
            return shop;
            }

        public Shop Delete( int id )
            {
            var shop = appDbContext.shop.Find(id);
            if (shop != null)
                {
                appDbContext.shop.Remove(shop);
                appDbContext.SaveChanges();
                }
            return shop;
            }

        public Shop Get( int id )
            {
            var shop = appDbContext.shop.Find(id);
            return shop;
            }

        public IEnumerable<Shop> GetAll()
            {
            return appDbContext.shop;
            }

        public Shop Update( Shop shop )
            {
            var Shops = appDbContext.shop.Attach(shop);
            Shops.State = EntityState.Modified;
            appDbContext.SaveChanges();
            return shop;
            }
        }
    }
