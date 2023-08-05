using ProjectFutureAdvannced.Models.Model;

namespace ProjectFutureAdvannced.Models.IRepository
    {
    public interface IUserRepository
        {
        public User Add( User user );
        public User Delete( string id );
        public User Get( string id );
        public IEnumerable<User> GetAll();
        public User Update( User user );
        }
    }
