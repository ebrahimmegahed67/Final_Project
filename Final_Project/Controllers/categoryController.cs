using Final_Project.@interface;
using Final_Project.Models;
using Microsoft.AspNetCore.Mvc;

namespace Final_Project.Controllers
{
    public class categoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        ICategoriesRepo categoryRepo;

      public categoryController(ICategoriesRepo _categoryRepo)
        {
            categoryRepo = _categoryRepo;
        }
        public IActionResult GetAll()
        {
            List<categories> categories = categoryRepo.GetAll();
            return View(categories);
        }

        public IActionResult GetById(int Id)
        {
            categories category = categoryRepo.GetById(Id);
            return View(category);
        }

        public IActionResult GoToAdd()
        {
            return View();
        }

        public IActionResult SaveAddedData(categories category)
        {
            categoryRepo.insert(category);
            
            return RedirectToAction("GetAll");
        }

        public IActionResult GoToEdit(int id)
        {
            categories category = categoryRepo.GetById(id);
            return View(category);
        }

        public IActionResult SaveEditData(categories categorie)
        {
            categoryRepo.update(categorie);
            return RedirectToAction("GetAll");
        }

        public IActionResult Delete(int id)
        {
            categories category = categoryRepo.GetById(id);
            categoryRepo.remove(id);
            return RedirectToAction("GetAll");
        }
    }
}
