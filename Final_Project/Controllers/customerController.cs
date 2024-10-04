using Final_Project.@interface;
using Final_Project.Models;
using Microsoft.AspNetCore.Mvc;

namespace Final_Project.Controllers
{
    public class customerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        ICustomerRepo customerRepo;
        public customerController(ICustomerRepo _customerRepo)
        {
            customerRepo = _customerRepo;
        }
        public IActionResult GetAll()
        {
            List<customers> customers = customerRepo.GetAll();
            return View(customers);
        }

        public IActionResult GetById(int Id)
        {
            customers customers = customerRepo.GetById(Id);  
            return View(customers);
        }

        public IActionResult GoToAdd()
        {
            return View();
        }

        public IActionResult SaveAddedData(customers customers)
        {
            customerRepo.insert(customers);
            return RedirectToAction("GetAll");
        }

        public IActionResult GoToEdit(int id)
        {
            customers customer = customerRepo.GetById(id);
            return View(customer);
        }

        public IActionResult SaveEditData(customers customers)
        {
            customerRepo.update(customers);
            return RedirectToAction("GetAll");
        }

        public IActionResult Delete(int id)
        {
            customers customers = customerRepo.GetById(id);
            customerRepo.remove(id);
            return RedirectToAction("GetAll");
        }
    }
}
