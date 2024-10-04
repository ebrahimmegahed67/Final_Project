using Final_Project.Models;

namespace Final_Project.@interface
{
    public interface ICategoriesRepo
    {
        List<categories> GetAll();
        categories GetById(int id);
        void insert(categories category);
        void update(categories categorie);
        void remove(int id);
    }
}