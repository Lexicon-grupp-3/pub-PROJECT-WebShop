﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebShopReactCore.Models
{
    /*
    public class Author
    {
        public int Id { get; set; }
        [DisplayName("Förnamn")]
        public string FirstName { get; set; }
        [DisplayName("Efternamn")]
        public string LastName { get; set; }
        public ICollection<AuthorBook> AuthorBooks { get; set; }

        [DisplayName("Namn")]
        public string FullName => $"{FirstName} {LastName}";
    }
    */
    public class Author
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Förnamn")]
        public string FirstName { get; set; }
        [DisplayName("Efternamn")]
        public string LastName { get; set; }
        public ICollection<Book> Books { get; set; }

        [DisplayName("Namn")]
        public string FullName => $"{FirstName} {LastName}";
    }
}
