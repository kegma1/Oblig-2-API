public interface ICategoryRepository
{
    IEnumerable<Category> GetAllCategorys();
    Category GetCategoryById(int id);
    void AddCategory(Category category);
    void UpdateCategory(Category category);
    void DeleteCategory(int id);
}