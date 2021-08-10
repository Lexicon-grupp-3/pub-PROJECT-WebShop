
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

        /*
        /// <summary>
        /// Collects all authors from the database.
        /// </summary>
        /// <returns>Returns an AuthorsViewModel containing a list of Author items.</returns>
        [HttpGet]
        public AuthorsViewModel AuthorList()
        {
            AuthorsViewModel authors = new AuthorsViewModel();
            authors.ListOfAuthors = _context.Authors.ToList();

            return authors;
        }
        */

        /*
        /// <summary>
        /// Collects all books from the database.
        /// </summary>
        /// <returns>Returns a BooksViewModel containing a list of Book items.</returns>
        [HttpGet]
        public BooksViewModel BookList()
        {
            BooksViewModel books = new BooksViewModel();
            books.ListOfBooks = _context.Books.Include(b => b.Authors).ToList();
            //books.ListOfBooks = new List<Book>();
            //foreach (var book in _context.Books.ToList())
            //{
            //    book.Authors = _context.Authors.Where(ab => ab.Id == book.Id).ToList();
            //    books.ListOfBooks.Add(book);
            //}

            return books;
        }
        */

        [HttpGet]
        public List<Book> BookList()
        {
            var ret = _context.Books.ToList();
                //.Include(book => book.AuthorsLink).ThenInclude(ab => ab.Author).ToList();

            return ret;
        }
    }
}
