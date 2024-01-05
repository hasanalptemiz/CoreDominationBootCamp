using CoreDominationBootCamp.Models;

namespace CoreDominationBootCamp.Services
{
    public class CategoryService
    {
        private static List<Category> categories = new List<Category>
        {
            new Category(1, "Electronics"),
            new Category(2, "Books"),
            // you can add other categories here.
        };

        public List<Category> GetAllCategories()
        {
            return categories;
        }

        public Category GetCategoryById(int categoryId)
        {
         
            return categories[categoryId]; 
        }
    }
}
