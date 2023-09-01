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
        //public Wishlist Add( Wishlist product )
        //    {
        //   _appDbContext.Wishlists.Add(product);
        //    _appDbContext.SaveChanges();
        //    return product;
        //    }

        //public Wishlist Delete( int UserId,int  ProductId )
        //    {
        //    var product = _appDbContext.Wishlists.Find(UserId,ProductId);
        //    if( product != null )
        //        {
        //        _appDbContext.Wishlists.Remove(product);
        //        _appDbContext.SaveChanges();
        //        }
        //    return product;
        //    }
        //public Wishlist GetByFk( int UserId, int ProductId )
        //    {
        //        return _appDbContext.Wishlists.Find(UserId, ProductId);
        //    }

        //public IEnumerable<Product> ProductInWishList(int UserId)
        //    {
        //    var products = _appDbContext.Wishlists.Where(e=>e.UserId==UserId)
        //    .Select(w => w.Product)
        //    .ToList();
        //    return products;
        //    }
        }
    }
