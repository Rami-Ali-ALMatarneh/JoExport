using Microsoft.EntityFrameworkCore;
using ProjectFutureAdvannced.Data;
using ProjectFutureAdvannced.Models.IRepository;
using ProjectFutureAdvannced.Models.Model;

namespace ProjectFutureAdvannced.Models.SqlRepository
    {
    public class SqlUserRepository:IUserRepository
        {
        private readonly AppDbContext appDbContext;
        public SqlUserRepository( AppDbContext appDbContext )
            {
            this.appDbContext = appDbContext;
            }
        public User Add( User User )
            {
            appDbContext.User.Add(User);
            appDbContext.SaveChanges();
            return User;
            }

        public User Delete( int id )
            {
            var Users = appDbContext.User.Find(id);
            if (Users != null)
                {
                appDbContext.User.Remove(Users);
                appDbContext.SaveChanges();
                }
            return Users;
            }

        public User Get( int id )
            {
            var User = appDbContext.User.Find(id);
            return User;
            }

        public IEnumerable<User> GetAll()
            {
            return appDbContext.User;
            }

        public User Update( User User )
            {
            var Users = appDbContext.User.Attach(User);
            Users.State = EntityState.Modified;
            appDbContext.SaveChanges();
            return User;
            }
        }
    }
