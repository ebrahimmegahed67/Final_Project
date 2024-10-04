using Final_Project.Models;

namespace Final_Project.@interface
{
    public interface ICustomerRepo
    {
        List<customers> GetAll();
        customers GetById(int id);
        void insert(customers customers);
        void update(customers customers);
        void remove(int id);
    }
}