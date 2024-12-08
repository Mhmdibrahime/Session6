using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Session6.Models;
using Session6.Models.ViewModels;

namespace Session6.Controllers
{
    public class AdminController : Controller
    {
        AppDbContext context = new AppDbContext();
        public IActionResult ViewBooks()
        {
            var books = context.Books.Include(x=>x.Author).Include(x=>x.Category).ToList();
            return View(books);
        }
        public IActionResult AddBook()
        {
            var model = new AddBookViewModel
            {
                AuthorList = context.Author.ToList(),
                Categories = context.Category.ToList()
            };
            return View(model);
        }
        [HttpPost]
        public IActionResult AddBook(AddBookViewModel model)
        {
            if(ModelState.IsValid)
            {
                var book = new Book
                {
                    Title = model.Title,
                    Description = model.Description,
                    Stock = model.Stock,
                    Price = model.Price,
                    NumberOfPages = model.NumberOfPages,
                    CategoryId = model.CategoryId,
                    AuthorId = model.AuthorId
                };
                context.Books.Add(book);
                context.SaveChanges();
                return RedirectToAction("ViewBooks");
            }
            return View(model);
        }
        public IActionResult ViewAuthors()
        {
           
            return View(context.Author.ToList());
        }
        public IActionResult AddAuthor()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddAuthor(AuthorsViewModel model) {
            if (ModelState.IsValid)
            {
                var author = new Author
                {
                    Name = model.Name
                };
                context.Author.Add(author);
                context.SaveChanges();
                return RedirectToAction("ViewAuthors");
            }
            else return View(model);
        }
        public IActionResult ViewCategories()
        {
            return View(context.Category.ToList());
        }
        public IActionResult AddCategory()
        {

            return View();
        }
        [HttpPost]
        public IActionResult AddCategory(CategoryViewModel model)
        {
            if (ModelState.IsValid)
            {
                var category = new Category
                {
                    Name = model.Name
                };
                context.Category.Add(category);
                context.SaveChanges();
                return RedirectToAction("ViewCategories");
            }
            return View();
        }

    }
}
