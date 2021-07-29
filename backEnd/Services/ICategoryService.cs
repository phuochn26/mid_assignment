using System.Collections.Generic;
using backEnd.Models;
using backEnd.Models.DTO;

namespace backEnd.Services{
    public interface ICategoryService{
        List<Category> GetCategories();
        Category GetCategoryById(int id);
        void CreateCategory(CategoryDTO category);
        void UpdateCategory(CategoryDTO category, int id);
        void DeleteCategory(int id);
    }
}