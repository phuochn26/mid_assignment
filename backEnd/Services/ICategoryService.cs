using System.Collections.Generic;
using backEnd.Models;
using backEnd.Models.DTO;

namespace backEnd.Services{
    public interface ICategoryService{
        List<Category> GetCategories();
        Category GetCategoryById(int id);
        bool CreateCategory(CategoryDTO category);
        bool UpdateCategory(CategoryDTO category, int id);
        bool DeleteCategory(int id);
    }
}