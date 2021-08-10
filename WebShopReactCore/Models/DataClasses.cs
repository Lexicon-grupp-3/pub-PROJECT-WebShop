using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebShopReactCore.Models
{
    public class Author
    {
        [Key]
        public int AuthorId { get; set; }
        [DisplayName("Förnamn")]
        public string FirstName { get; set; }
        [DisplayName("Efternamn")]
        public string LastName { get; set; }
        public ICollection<AuthorBook> BooksLink { get; set; }

        [DisplayName("Namn")]
        public string FullName => $"{FirstName} {LastName}";
    }


    public class AuthorBook
    {
        public int BookId { get; set; }
        
        public int AuthorId { get; set; }

        public byte Order { get; set; }
        

        public Book Book { get; set; }
        public Author Author { get; set; }

    }

    /*public class AuthorsViewModel
    {
        public List<Author> ListOfAuthors { get; set; }
    }*/

    public class Book
    {
        [Key]
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string PictureRef { get; set; }
        public string ISBN { get; set; }
        public decimal Price { get; set; }
        public ICollection<AuthorBook> AuthorsLink { get; set; }
    }

    /*public class BooksViewModel
    {
        public List<Book> ListOfBooks { get; set; }
    }
    */
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
