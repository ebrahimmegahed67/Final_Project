using Final_Project.Models;

namespace Final_Project.@interface
{
    public interface IProductRepo
    {
        List<products> GetAll();
        products GetById(int id);
        void insert(products product);
        void update(int id);
        void remove(int id);
    }
}