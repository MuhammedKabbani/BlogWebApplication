using EntityLayer.Concrate;

namespace DataAccessLayer.Abstract
{
    public interface IBlogRepository:IRepository<Blog>
    {
        public List<Blog> GetBlogsWithCategories();
    }
}
