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
            _appDbContext..Add(card);
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
        public IEnumerable<Card> DeleteAllCardByProductId( int ProductId )
            {
            var Cards = _appDbContext.Card.Where(e => e.ProductId == ProductId);
            if (Cards != null)
                {
                foreach (var card in Cards)
                    {
                    _appDbContext.Card.Remove(card);
                    _appDbContext.SaveChanges();
                    }
                }
            return Cards;
            }
        }
    }
