using System.Collections.Generic;

namespace backEnd.Models.DTO
{
    public class CategoryDTO
    {
        public string CategoryName { get; set; }
        public List<Book> Books { get; set; }
    }
}