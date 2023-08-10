using ProjectFutureAdvannced.Models.Model.AccountUser;
using ProjectFutureAdvannced.ViewModels.AdminViewModel;

namespace ProjectFutureAdvannced.Models.IRepository
{
    public interface IAdminRepository
        {
        public Admin Add(Admin admin);
        public Admin Update(Admin admin);
        public Admin Delete(string Id);
        public Admin Get(string Id);
        public Admin GetByFK(string Fk);
        }
    }
