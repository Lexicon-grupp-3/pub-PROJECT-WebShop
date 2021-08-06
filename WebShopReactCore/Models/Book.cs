using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace WebShopReactCore.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string PictureRef { get; set; }
        public string ISBN { get; set; }
        public decimal Price { get; set; }
        public ICollection<AuthorBook> AuthorBooks { get; set; }

    }

}
