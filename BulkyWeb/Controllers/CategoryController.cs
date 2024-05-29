using BulkyWeb.Data;
using BulkyWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace BulkyWeb.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db) // ApplicationDbContext is from program.cs service
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Category> objCategoryList = _db.Categories.ToList();
            return View(objCategoryList);
        }

        public IActionResult Create() 
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category obj)
        {
            _db.Categories.Add(obj); //save in ToList
            _db.SaveChanges();// save in database
            return RedirectToAction("Index"); //return RedirectToAction("Index", "Category"); you can redirect to other controller
        }
    }
}
