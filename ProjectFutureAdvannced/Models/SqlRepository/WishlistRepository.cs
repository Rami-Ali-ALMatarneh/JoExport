using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using ProjectFutureAdvannced.Data;
using ProjectFutureAdvannced.Models.IRepository;
using ProjectFutureAdvannced.Models.Model;
using ProjectFutureAdvannced.Models.Model.AccountUser;
using System.Linq;
using System.Linq.Expressions;

namespace ProjectFutureAdvannced.Models.SqlRepository
    {
    public class WishlistRepository : IWishlistRRepository
        {
        public readonly AppDbContext _appDbContext;
        public WishlistRepository( AppDbContext _appDbContext )
            {
            this._appDbContext = _appDbContext;
            }
        public Wishlist Add( Wishlist card )
            {
            _appDbContext.Wishlists.Add(card);
            _appDbContext.SaveChanges();
            return card;
            }
        public IEnumerable<Product> GetAllProductByUserId( int userId )
            {
            return _appDbContext.Card
                .Where(card => card.UserId == userId)
                .Select(card => card.Product)
                .ToList();
            }
        public IEnumerable<Wishlist> DeleteAllWishListByProductId( int ProductId )
            {
            var Cards = _appDbContext.Wishlists.Where(e => e.ProductId == ProductId);
            if (Cards != null)
                {
                foreach (var card in Cards)
                    {
                    _appDbContext.Wishlists.Remove(card);
                    _appDbContext.SaveChanges();
                    }
                }
            return Cards;
            }
        }
    }
