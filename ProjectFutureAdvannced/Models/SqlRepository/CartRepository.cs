using ProjectFutureAdvannced.Data;
using ProjectFutureAdvannced.Models.Model;

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

    }
public interface ICartRepository
    {
    public Card Add(Card card);
    }

