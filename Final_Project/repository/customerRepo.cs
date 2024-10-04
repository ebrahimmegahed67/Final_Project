using Final_Project.@interface;
using Final_Project.Models;
using static System.Object;

namespace Final_Project.repository
{
    public class customerRepo:ICustomerRepo
    {
        FinalProjectContext context;
        public customerRepo(FinalProjectContext _context)
        {
            context = _context;
        }
        public List<customers> GetAll()
        {
            List<customers> customers = context.customers.ToList();
            return customers;
        }
        public customers GetById(int id)
        {
            customers customers = context.customers.FirstOrDefault(s=>s.Id == id);
            return customers;
        }
        public void insert(customers customers)
        {
            context.customers.Add(customers);
            context.SaveChanges();
        }
        public void update(customers customers)
        {
            context.customers.Update(customers);
            context.SaveChanges();
        }
        public void remove(int id)
        {
            customers customers = GetById(id);
            context.customers.Remove(customers);
            context.SaveChanges();
        }
    }
}
