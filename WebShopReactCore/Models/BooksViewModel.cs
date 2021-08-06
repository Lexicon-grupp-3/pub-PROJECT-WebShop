using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebShopReactCore.Models
{
    public class BooksViewModel
    {
        public List<BookInfoLine> ListOfBooks { get; set; }
    }
    public class BookInfoLine
    {
        public Book bookV { get; set; }
        public string AuthorFullName { get; set; }
    }
}
