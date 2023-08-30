using ProjectFutureAdvannced.Models.Model;
using System.Linq.Expressions;

namespace ProjectFutureAdvannced.Models.IRepository
    {
    public interface IProductRepository
        {
        public Product Add( Product product );
        public Product Update(Product product) ;
        public Product Delete(int id) ;
        public Product GetById( int id );
        public IEnumerable<Product> Find( Expression<Func<Product, bool>> predicate ) ;

        public IEnumerable<Product> GetAll() ;
       // public IEnumerable<Product> GetAllByFK(int id) ;
        }
    }
