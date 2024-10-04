using Final_Project.@interface;
using Final_Project.Models;
using Final_Project.repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Final_Project.Controllers
{
    public class orderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        IOrderRepo orderRepo;
        ICustomerRepo customerRepo;
         public orderController(IOrderRepo _orderRepo, ICustomerRepo _customerRepo)
        {
            orderRepo = _orderRepo;
            customerRepo = _customerRepo;
        }
        public IActionResult GetAll()
        {
            List<orders> orders = orderRepo.GetAll();
            return View(orders);
        }

        public IActionResult GetById(int Id)
        {
            orders order = orderRepo.GetById(Id);
            return View(order);
        }

        public IActionResult GoToAdd()
        {
            List<customers> customer = customerRepo.GetAll();
            ViewBag.CustomerId = customer;
            return View();
        }

        public IActionResult SaveAddedData(orders orders)
        {
            orderRepo.insert(orders);
            return RedirectToAction("GetAll");
        }

        public IActionResult GoToEdit(int id)
        {
            orders order = orderRepo.GetById(id);
            List<customers> customer = customerRepo.GetAll();
            ViewBag.CustomerId = customer;
            return View(order);
        }

        public IActionResult SaveEditData(orders orders)
        {
            orderRepo.update(orders);
            return RedirectToAction("GetAll");
        }

        public IActionResult Delete(int id)
        {
            orderRepo.delete(id);
            return RedirectToAction("GetAll");
        }
    }
}
