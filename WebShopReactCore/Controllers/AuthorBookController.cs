
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


        [HttpGet]
        public List<BookItem> BookList()
        {
            List<BookItem> ret = new List<BookItem>();
            List<Book> items = _context.Books.Include(book => book.AuthorsLink).ThenInclude(ab => ab.Author).ToList();
            
            foreach(Book item in items)
            {
                BookItem tmp = new BookItem();

                tmp.BookId = item.BookId;
                tmp.Description = item.Description;
                tmp.ISBN = item.ISBN;
                tmp.PictureRef = item.PictureRef;
                tmp.Price = item.Price;
                tmp.Title = item.Title;
                tmp.Authors = new List<AuthorItem>();

                foreach(AuthorBook at in item.AuthorsLink)
                {
                    AuthorItem tmpAuth = new AuthorItem();

                    tmpAuth.AuthorId = at.AuthorId;
                    tmpAuth.FirstName = at.Author.FirstName;
                    tmpAuth.LastName = at.Author.LastName;

                    tmp.Authors.Add(tmpAuth);
                }

                ret.Add(tmp);
            }

            return ret;
        }

        [HttpGet]
        public List<Book> BookList1()
        {
            return _context.Books.Include(book => book.AuthorsLink).ThenInclude(ab => ab.Author).ToList<Book>();
        }
    }
}
