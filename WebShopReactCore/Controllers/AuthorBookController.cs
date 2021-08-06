
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShopReactCore.Data;
using WebShopReactCore.Models;

namespace WebShopReactCore.Controllers
{
    public class AuthorBookController : Controller
    {
        private readonly AppStoreDbContext _context;
        public AuthorBookController(AppStoreDbContext ctx)
        {
            _context = ctx;
        }


        [HttpGet]
        public IEnumerable<Author> Index3()
        {
            AuthorsViewModel authors = new AuthorsViewModel();
            authors.ListOfAuthors = _context.Authors.ToList();

            return authors.ListOfAuthors;
        }


        public AuthorsViewModel Index()
        {
            AuthorsViewModel authors = new AuthorsViewModel();
            authors.ListOfAuthors = _context.Authors.OrderBy(a => a.LastName).ToList();

            return authors;
        }

        public AuthorDetailViewModel AuthorDetail()
        {
            AuthorDetailViewModel author = new AuthorDetailViewModel();
            author.FirstName = "Kalle";
            author.LastName = "Fransson";
            return author;
        }
        public BooksViewModel Books()
        {
            BooksViewModel books = new BooksViewModel();
            books.ListOfBooks = new List<BookInfoLine>();
            foreach (var book1 in _context.Books.OrderBy(b => b.Title).ToList())
            {
                BookInfoLine bookInfoLine = new BookInfoLine();
                bookInfoLine.bookV = book1;
                // Ta fram Id för alla författare till denna bok
                book1.AuthorBooks = _context.AuthorBooks.Where(ab => ab.BookId == book1.Id).ToList();
                foreach (var a1 in book1.AuthorBooks)  // och hämta namnen för respektive
                {
                    string x = _context.Authors.Where(a2 => a2.Id == a1.AuthorId).FirstOrDefault().FullName;
                    if (bookInfoLine.AuthorFullName is null)
                    { bookInfoLine.AuthorFullName = x; }
                    else
                    { bookInfoLine.AuthorFullName = bookInfoLine.AuthorFullName + ", " + x; }
                }
                books.ListOfBooks.Add(bookInfoLine);
            }

            return books;
        }

        // GET: AuthorBookController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AuthorBookController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AuthorBookController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AuthorBookController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AuthorBookController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AuthorBookController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AuthorBookController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
