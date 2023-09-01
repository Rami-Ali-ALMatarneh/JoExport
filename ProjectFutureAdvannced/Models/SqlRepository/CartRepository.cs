using ProjectFutureAdvannced.Data;
using ProjectFutureAdvannced.Models.Model;
using ProjectFutureAdvannced.Models.Model.AccountUser;
using System;
using System.Linq;

namespace ProjectFutureAdvannced.Models.SqlRepository;
    public class CartRepository: ICartRepository
    {
    private readonly AppDbContext _appDbContext;
    public CartRepository( AppDbContext _appDbContext )
    {
        this._appDbContext = _appDbContext;
    }
    public Card Add( Card card )
        {
        _appDbContext.Card.Add( card );
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
public interface ICartRepository
    {
    public Card Add(Card card);
    public IEnumerable<Card> DeleteAllCardByProductId( int ProductId );
    public IEnumerable<Product> GetAllProductByUserId( int userId );
    }

