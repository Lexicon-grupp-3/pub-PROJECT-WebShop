using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebShopReactCore.Models
{
    public class ListBooks
    {
        public ListBooks() { }
        public ListBooks(ICollection<Book> list)
        {
            Books = list.ToList();
        }
        public List<Book> Books { get; set; }
    }
}
