using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICategoryService
    {
        public void AddCategory(Category c);
        public void DeleteCategory(Category c);
        public void UpdateCategory(Category c);
        public Category GetCategoryById(int id);
        public List<Category>GettAllCategories();
    }
}
