
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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


        public AuthorsViewModel Index()
        {
            AuthorsViewModel authors = new AuthorsViewModel();
            authors.ListOfAuthors = _context.Authors.OrderBy(a => a.LastName).ToList();

            return authors;
        }

        public AuthorsViewModel Authors()
        {
            AuthorsViewModel authors = new AuthorsViewModel();
            authors.ListOfAuthors = _context.Authors.OrderBy(a => a.LastName).ToList();

            return authors;
        }

        [HttpPost]
        public AuthorDetailViewModel AuthorEdit([FromBody] Author author)
        {
            AuthorDetailViewModel authorD = new AuthorDetailViewModel();
            if (author.Id == 0)  //create
            {
                _context.Authors.Add(author);
                _context.SaveChanges();
            }
            else //update
            {
                Author author1 = _context.Authors.Find(author.Id);

                author1.FirstName = author.FirstName;
                author1.LastName = author.LastName;
                //_context.Entry(author1).State = EntityState.Modified;
                _context.Authors.Update(author1);
                _context.SaveChanges();
            }
            authorD.FirstName = author.FirstName;
            authorD.LastName = author.LastName;

            return authorD;
        }
        public void AuthorDelete([FromBody] Author author)
        {
            Author author1 = _context.Authors.Find(author.Id);

            //author1.FirstName = author.FirstName;
            //author1.LastName = author.LastName;
            //_context.Entry(author1).State = EntityState.Modified;
            _context.Authors.Remove(author1);
            _context.SaveChanges();

            return;
        }


        // --------- Books  ---------------- 
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

        [HttpPost]
        public Boolean BookEdit([FromBody]Book book)
        {
            if (book.Id == 0)  //create
            {
                _context.Books.Add(book);
            }
            else //update
            {
                Book book1 = _context.Books.Find(book.Id);
                book1 = book;  //?
                book1.Title = book.Title;
                book1.Description = book.Description;
                //_context.Entry(book1).State = EntityState.Modified;
                _context.Books.Update(book1);
            }
            _context.SaveChanges();
            //Book bookD = new Book();
            //bookD.Title = book.Title;
            //bookD.Description = book.Description;

            return true;
        }
        // ----------------------------------------------------------
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
