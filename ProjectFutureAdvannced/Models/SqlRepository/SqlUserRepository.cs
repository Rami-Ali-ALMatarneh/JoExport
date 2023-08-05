using Microsoft.EntityFrameworkCore;
using ProjectFutureAdvannced.Data;
using ProjectFutureAdvannced.Models.IRepository;
using ProjectFutureAdvannced.Models.Model;

namespace ProjectFutureAdvannced.Models.SqlRepository
    {
    public class SqlUserRepository : IUserRepository
        {
        private readonly AppDbContext appDbContext;
        public SqlUserRepository( AppDbContext appDbContext )
            {
            this.appDbContext = appDbContext;
            }
        public User Add( User user )
            {
            appDbContext.user.Add(user);
            appDbContext.SaveChanges();
            return user;
            }

        public User Delete( int id )
            {
            var users = appDbContext.user.Find(id);
            if (users != null)
                {
                appDbContext.user.Remove(users);
                appDbContext.SaveChanges();
                }
            return users;
            }

        public User Get( int id )
            {
            var user = appDbContext.user.Find(id);
            return user;
            }

        public IEnumerable<User> GetAll()
            {
            return appDbContext.user;
            }

        public User Update( User user )
            {
            var users = appDbContext.user.Attach(user);
            users.State = EntityState.Modified;
            appDbContext.SaveChanges();
            return user;
            }
        }
    }
