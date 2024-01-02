using CoreDominationBootCamp.Models;

namespace Services
{
    public class CategoryService
    {
        private static List<Category> categories = new List<Category>
        {
            new Category(1, "Electronics"),
            new Category(2, "Books"),
            // Diğer kategorileri buraya ekleyebilirsiniz.
        };

        public List<Category> GetAllCategories()
        {
            return categories;
        }

        public Category GetCategoryById(int categoryId)
        {
            return categories.Find(c => c.Id == categoryId);
        }
    }
}
