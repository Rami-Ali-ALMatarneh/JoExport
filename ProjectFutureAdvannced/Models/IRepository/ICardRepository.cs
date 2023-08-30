using ProjectFutureAdvannced.Models.Model;
using System.Linq.Expressions;

namespace ProjectFutureAdvannced.Models.IRepository
    {
    public interface ICardRepository
        {
        public Card Add(Card card);
        public Card Update(Card card);
        public Card Delete(int Id);
        public IEnumerable<Card> GetAll();
        public Card GetCard(int id);
        public IEnumerable<Card> Find( Expression<Func<Card, int, bool>> predicate);
        }
    }
