using ProjectFutureAdvannced.Models.Model;

namespace ProjectFutureAdvannced.Models.IRepository
    {
    public interface IUserRepository
        {
        public User Add( User user );
        public User Delete( int id );
        public User Get( int id );
        public IEnumerable<User> GetAll();
        public User Update( User user );
        }
    }
