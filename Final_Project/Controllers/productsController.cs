using Final_Project.@interface;
using Final_Project.Models;
using Final_Project.repository;
using Microsoft.AspNetCore.Mvc;

namespace Final_Project.Controllers
{
    public class productsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
      

        IProductRepo productRepo; 
        public productsController(IProductRepo _productRepo)
        {
            productRepo = _productRepo;
        }
        public IActionResult GetAll()
        {
            List<products> products = productRepo.GetAll();  
            return View(products);
        }

        
        public IActionResult GetById(int Id)
        {
            products product = productRepo.GetById(Id);  
            return View(product);
        }

        public IActionResult GoToAdd()
        {
            return View();
        }
        public IActionResult SaveAddedData(products product)
        {
            productRepo.insert(product);
                return RedirectToAction("GetAll");
        }
        public IActionResult GoToEdit(int id)
        {
            products product = productRepo.GetById(id);   
            return View(product);
        }
        public IActionResult saveEditData(int id)
        {
            productRepo.update(id);
            
            return RedirectToAction("GetAll");
        }
        public IActionResult Delete(int id)
        {
            products product = productRepo.GetById(id); 
           
            productRepo.remove(id);
            return RedirectToAction("GetAll");
        }
    }
}
