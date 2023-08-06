using ProjectFutureAdvannced.Models.Model;

namespace ProjectFutureAdvannced.Models.IRepository
{
    public interface ICategoryRepository
        {
        public Category Add(Category category);
        public Category Delete( int id);
        public Category Get(int id);
        public IEnumerable<Category> GetAll();
        public Category Update(Category category);
        }
    }
