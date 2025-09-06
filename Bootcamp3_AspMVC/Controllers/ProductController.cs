using Bootcamp3_AspMVC.Data;
using Bootcamp3_AspMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Bootcamp3_AspMVC.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductController(ApplicationDbContext context)
        {
            _context = context;

        }
        private void CreateCategory(int selected = 0)
        {
            IEnumerable<Category> categories = _context.Categories.ToList();
            SelectList selectListItems = new SelectList(categories, "Id", "Name", selected);
            ViewBag.CategoryList = selectListItems;
        }
        public IActionResult Index()
        {
            IEnumerable<Product> product= _context.Products.ToList();


            return View(product);
        }


        
        public IActionResult Create()
        {
            CreateCategory();
           return View();
        }


        [HttpPost]
        public IActionResult Create(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public IActionResult Edit(int Id)
        {
            var product = _context.Products.Find(Id);
            CreateCategory();
            return View(product);
        }



        [HttpPost]
        public IActionResult Edit(Product product)
        {
            _context.Products.Update(product);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }


        [HttpGet]
        public IActionResult Delete(int Id)
        {
            var product = _context.Products.Find(Id);
            return View(product);
        }



        [HttpPost]
        public IActionResult Delete(Product product) 
        {
            _context.Products.Remove(product);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }


    }
}
