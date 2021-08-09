using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebShopReactCore.Models
{
    public class AuthorBook
    {
        public int AuthorId { get; set; }

        public int BookId { get; set; }
    }
}
