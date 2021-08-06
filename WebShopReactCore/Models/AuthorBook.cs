using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebShopReactCore.Models
{
    public class AuthorBook
    {
        [Key]
        public int AuthorId { get; set; }

        [Key]
        public int BookId { get; set; }
    }
}
