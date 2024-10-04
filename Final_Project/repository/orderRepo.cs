using Final_Project.Models;
using Final_Project.@interface;
using static System.Object;
namespace Final_Project.repository
{
    public class orderRepo:IOrderRepo
    {
        FinalProjectContext context;
        public orderRepo(FinalProjectContext _context)
        {
            context = _context;
        }
        public List<orders> GetAll()
        {
            List<orders> order = context.orders.ToList();
            return order;
        }
        public orders GetById(int id)
        {
            orders order = context.orders.SingleOrDefault(s => s.Id == id);
            return order;
        }
        public void insert(orders order)
        {
            context.orders.Add(order);
            context.SaveChanges();
        }
        public void update(orders order)
        {
            context.orders.Update(order);
            context.SaveChanges();
        }
        public void delete(int id)
        {
            orders order = context.orders.SingleOrDefault(s => s.Id == id);
            context.orders.Remove(order);
            context.SaveChanges();  
        }
    }
}
