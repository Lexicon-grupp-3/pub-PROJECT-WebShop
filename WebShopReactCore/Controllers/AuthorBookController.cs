
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
            authors.ListOfAuthors = _context.Authors.ToList();

            return authors;
        }

        public BooksViewModel Books()
        {
            BooksViewModel books = new BooksViewModel();
            books.ListOfBooks = _context.Books.ToList();
            foreach (var book in books.ListOfBooks)
                {
                    book.AuthorBooks = _context.AuthorBooks.Where(ab => ab.BookId == book.Id).ToList();
                foreach (var ab in book.AuthorBooks)
                {
                    ab.Author = _context.Authors.Where(a => a.Id == ab.AuthorId).FirstOrDefault();
                }
            }

            return books;
        }
        public BooksViewModel2 Books2()
        {
            BooksViewModel2 books = new BooksViewModel2();
            books.ListOfBooks = new List<BookInfoLine>();
            foreach (var book in _context.Books.ToList())
            {
                book.AuthorBooks = _context.AuthorBooks.Where(ab => ab.BookId == book.Id).ToList();
                foreach (var ab in book.AuthorBooks)
                {
                    ab.Author = _context.Authors.Where(a => a.Id == ab.AuthorId).FirstOrDefault();
                }

                BookInfoLine bookInfoLine = new BookInfoLine();
                bookInfoLine.Id = book.Id;
                bookInfoLine.Title = book.Title;
                bookInfoLine.ISBN = book.ISBN;
                bookInfoLine.Price = book.Price;
                bookInfoLine.AuthorFullName = _context.Authors.Where(a => a.Id == book.AuthorBooks.First().AuthorId).FirstOrDefault().FullName;
                books.ListOfBooks.Add(bookInfoLine);
            }

            return books;
        }


        // GET: AuthorBookController
        public ActionResult Index2()
        {
            //var rng = new Random();
            //return Enumerable.Range(1, 5).Select(index => new Author
            //{
            //    FirstName = "Kalle",
            //    LastName = "Olsson"
            //})
            //.ToArray();
            return View("text från AuthorBookController");
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
