using BusinessLayer.Abstract;
using DataAccessLayer.Repositories;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrate
{
    public class CategoryService : ICategoryService
    {
        CategoryRepository _repo;
        public CategoryService()
        {
            _repo = new CategoryRepository();

        }
        public void AddCategory(Category c)
        {
            _repo.Add(c);
        }

        public void DeleteCategory(Category c)
        {
            _repo.Delete(c);
        }

        public Category GetCategoryById(int id)
        {
            return _repo.Get(id);
        }

        public List<Category> GettAllCategories()
        {
            return _repo.GetAll();
        }

        public void UpdateCategory(Category c)
        {
            _repo.Update(c);
        }
    }
}
