using ProjectFutureAdvannced.Models.Model.AccountUser;

namespace ProjectFutureAdvannced.Models.IRepository
{
    public interface IAdminRepository
        {
        public Admin Add(Admin admin);
        public Admin Update(Admin admin);
        public Admin Delete(string Id);
        public Admin Get(string Id);
        }
    }
