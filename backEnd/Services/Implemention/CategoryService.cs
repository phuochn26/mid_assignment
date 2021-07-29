using System;
using System.Collections.Generic;
using System.Linq;
using backEnd.Models;
using backEnd.Models.DTO;
using backEnd.Services;

namespace backEnd.Services.Implemention
{
    public class CategoryService : ICategoryService
    {
        private DataContext _dataContext;
        public CategoryService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public List<Category> GetCategories()
        {
            return _dataContext.Categories.ToList();
        }
        public Category GetCategoryById(int id)
        {
            return _dataContext.Categories.Where(s => s.CategoryId == id).FirstOrDefault();
        }
        public void CreateCategory(CategoryDTO category)
        {
            using var transation = _dataContext.Database.BeginTransaction();
            try
            {
                var newCategory = new Category()
                {
                    CategoryName = category.CategoryName,
                };
                _dataContext.Categories.Add(newCategory);
                _dataContext.SaveChanges();
                transation.Commit();
            }
            catch(Exception)
            {
                return;
            }
        }

        public void UpdateCategory(CategoryDTO category, int id)
        {
            using var transation = _dataContext.Database.BeginTransaction();
            try
            {
                var updateCategory = _dataContext.Categories.Where(u => u.CategoryId == id).FirstOrDefault();
                updateCategory.CategoryName = category.CategoryName;

                _dataContext.SaveChanges();
                transation.Commit();
            }
            catch(Exception)
            {
                return;
            }
        }

        public void DeleteCategory(int id)
        {
            
            using var transation = _dataContext.Database.BeginTransaction();
            try
            {
                var category = _dataContext.Categories.Where(u => u.CategoryId == id).FirstOrDefault();
                _dataContext.Categories.Remove(category);
                _dataContext.SaveChanges();
                transation.Commit();
            }
            catch(Exception)
            {
                return;
            }
        }
    }
}