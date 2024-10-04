using Final_Project.@interface;
using Final_Project.Models;
namespace Final_Project.repository
{
    public class productRepo:IProductRepo
    {
        FinalProjectContext context;
        public productRepo(FinalProjectContext _context)
        {
            context = _context;
        }

        public List<products> GetAll()
        {
            List<products> products = context.products.ToList();
            return products;
        }
        public products GetById(int id)
        {
            products product=context.products.SingleOrDefault(s=>s.id==id);
            return product;
        }
        public void insert(products product)
        {
            context.products.Add(product);
            context.SaveChanges();
        }
        public void update(int id)
        {
            products product=context.products.SingleOrDefault(s=>s.id== id);
            context.products.Update(product);
            context.SaveChanges();
        }
        public void remove(int id)
        {
            products product = context.products.SingleOrDefault(s => s.id == id);
            context.products.Remove(product);
            context.SaveChanges();
        }
    }
}
