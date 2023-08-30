using Microsoft.EntityFrameworkCore;
using ProjectFutureAdvannced.Data;
using ProjectFutureAdvannced.Models.IRepository;
using ProjectFutureAdvannced.Models.Model;
using ProjectFutureAdvannced.Models.Model.AccountUser;
using System.Linq.Expressions;

namespace ProjectFutureAdvannced.Models.SqlRepository
    {
    public class SqlCardRepository:ICardRepository
        {
        private readonly AppDbContext appDbContext;
        public SqlCardRepository( AppDbContext appDbContext )
            {
            this.appDbContext = appDbContext;
            }
        public Card Add( Card Card )
            {
            appDbContext.Card.Add(Card);
            appDbContext.SaveChanges();
            return Card;
            }

        public Card Delete( int id )
            {
            var Cards = appDbContext.Card.Find(id);
            if (Cards != null)
                {
                appDbContext.Card.Remove(Cards);
                appDbContext.SaveChanges();
                }
            return Cards;
            }

        public Card GetCard( int id )
            {
            var Card = appDbContext.Card.Find(id);
            return Card;
            }

        public IEnumerable<Card> GetAll()
            {
            return appDbContext.Card;
            }

        public Card Update( Card Card )
            {
            var Cards = appDbContext.Card.Attach(Card);
            Cards.State = EntityState.Modified;
            appDbContext.SaveChanges();
            return Card;
            }
        public IEnumerable<Card> Find( Expression<Func<Card, int, bool>> predicate)
            {
            return appDbContext.Card.Where(predicate);
            }
        }
    }
