using Microsoft.EntityFrameworkCore;
using ProjectFutureAdvannced.Data;
using ProjectFutureAdvannced.Models.IRepository;
using ProjectFutureAdvannced.Models.Model;
using ProjectFutureAdvannced.Models.Model.AccountUser;
using System.Linq.Expressions;

namespace ProjectFutureAdvannced.Models.SqlRepository
    {
    public class SqlProductRepository : IProductRepository
        {
        private readonly AppDbContext appDbContext;
        public SqlProductRepository( AppDbContext appDbContext )
            {
            this.appDbContext = appDbContext;
            }
        public Product Add( Product product )
            {
            appDbContext.products.Add( product );
            appDbContext.SaveChanges();
            return product;

            }

        public Product Delete( int id )
            {
            var product = appDbContext.products.Find(id);
            if (product != null)
                {
                appDbContext.products.Remove(product);
                appDbContext.SaveChanges();
                }
            return product;
            }

        public IEnumerable<Product> GetAll()
            {
            return appDbContext.products;
                }

        public IEnumerable<Product> Find( Expression<Func<Product, bool>> predicate )
            {
            return appDbContext.products.Where(predicate);
            }

        public Product GetById( int id )
            {
            return appDbContext.products.Find(id);
            }

        public Product Update( Product productt )
            {
            var product = appDbContext.products.Attach(productt);
            product.State = EntityState.Modified;
            appDbContext.SaveChanges();
            return productt;
            }
        }
    }
