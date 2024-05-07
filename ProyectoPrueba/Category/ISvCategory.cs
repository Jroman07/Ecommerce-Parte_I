using Entidades;

namespace Services.Category
{
    public interface ISvCategory
    {
        //reads
        public List<Category> GetAllCategories();

        public Category GetCategoryById(int IdCategory);

        //writes
        public Category AddCategory(Category category);
    }
}
