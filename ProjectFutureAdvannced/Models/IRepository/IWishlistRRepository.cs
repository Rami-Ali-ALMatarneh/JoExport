using ProjectFutureAdvannced.Models.Model;
using ProjectFutureAdvannced.Models.Model.AccountUser;
using System.Linq.Expressions;

namespace ProjectFutureAdvannced.Models.IRepository
    {
    public interface IWishlistRRepository
        {
        public Wishlist Add( Wishlist wishlist );
        public IEnumerable<Wishlist> DeleteAllCardByProductId( int ProductId );
        public IEnumerable<Product> GetAllProductByUserId( int userId );
        }
    }
