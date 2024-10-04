using Final_Project.Models;

namespace Final_Project.@interface
{
    public interface IOrderRepo
    {
        List<orders> GetAll();
        orders GetById(int id);
        void insert(orders order);
        void update(orders order);
        void delete(int id);
    }
}
