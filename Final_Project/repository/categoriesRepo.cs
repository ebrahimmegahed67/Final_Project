using Final_Project.@interface;
using Final_Project.Models;
namespace Final_Project.repository
{
    public class categoriesRepo:ICategoriesRepo
    {
        FinalProjectContext context;
        public categoriesRepo(FinalProjectContext _context)
        {
            context = _context;
        }
        public List<categories> GetAll()
        {
            List<categories> categorie = context.categories.ToList();
            return categorie;
        }
        public categories GetById(int id)
        {
            categories categories=context.categories.SingleOrDefault(s=>s.Id==id);
            return categories;
        }
        public void insert(categories category)
        {
            context.categories.Add(category);
            context.SaveChanges();
        }
        public void update(categories categorie)
        {
            context.categories.Update(categorie);
            context.SaveChanges();
        }
        public void remove(int id)
        {
            categories categories = context.categories.SingleOrDefault(s => s.Id == id);
            context.categories.Remove(categories);
            context.SaveChanges();
        }

    }
}
