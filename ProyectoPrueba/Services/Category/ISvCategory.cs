using Entidades;

namespace ProyectoPrueba.Services.Services_Category
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
