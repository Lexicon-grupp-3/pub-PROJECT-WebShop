using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using WebShopReactCore.Data;

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

    public class AuthorItem
    {
        public int AuthorId { get; set; }
        [DisplayName("Förnamn")]
        public string FirstName { get; set; }
        [DisplayName("Efternamn")]
        public string LastName { get; set; }
        [DisplayName("Namn")]
        public string FullName => $"{FirstName} {LastName}";

        public List<BookItem> Books { get; set; }
    }


    public class AuthorBook
    {
        public int BookId { get; set; }
        
        public int AuthorId { get; set; }

        public byte Order { get; set; }
        

        public Book Book { get; set; }
        public Author Author { get; set; }

    }

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

    public class BookItem 
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string PictureRef { get; set; }
        public string ISBN { get; set; }
        public decimal Price { get; set; }
        public List<AuthorItem> Authors { get; set; }
    }

    public class ListBooks
    {
        public ListBooks() { }
        public ListBooks(ICollection<Book> list)
        {
            Books = list.ToList();
        }
        public List<Book> Books { get; set; }
    }

    /***** In the following section the sections commented out are not imlemented in this application *****/
    public class AppUserData : ApplicationUser
    {
        public AppUserData(ApplicationUser user, ApplicationDbContext ctx) : base(user)
        {
            /* NOT Implemented in this application. */
            //City = ctx.Cities.Find(user.CityId);
            //Country = ctx.Countries.Find(user.CountryId);
            Id = user.Id;
            FirstName = user.FirstName;
            LastName = user.LastName;
            Email = user.Email;
            PasswordHash = user.PasswordHash;
            //CityName = City.Name;
            //CountryName = Country.Name;
        }

        public string CityName { get; set; }
        public string CountryName { get; set; }
        //public CityClass City { get; }
        //public CountryClass Country { get; }
    }

    /*
    public class CityClass
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("CountryClass")]
        public int CountryId { get; set; }
        public List<ApplicationUser> Users { get; set; }

        public string Name { get; set; }


    }

    
    public class CountryClass
    {
        [Key]
        public int Id { get; set; }

        public List<CityClass> Cities { get; set; }

        public List<ApplicationUser> Users { get; set; }

        public string Name { get; set; }
    }

    public class Countries
    {
        public List<CountryClass> List { get; set; }

        public Countries()
        {
            List = new List<CountryClass>();
        }

        public void LoadCountries(ApplicationDbContext ctx)
        {
            var _list = ctx.Countries;
            foreach (CountryClass country in _list)
            {
                List.Add(country);
            }
        }
    }

    public class Cities
    {
        public List<CityData> List { get; set; }

        public void LoadCities(ApplicationDbContext ctx)
        {
            List = new List<CityData>();
            var _list = ctx.Cities;
            foreach (CityClass city in _list)
            {
                var cityData = new CityData(city.CountryId, ctx);
                cityData.Name = city.Name;
                cityData.Id = city.Id;
                List.Add(cityData);
            }
        }
    }

    public class CityData : CityClass
    {
        public CityData(int countryId, ApplicationDbContext ctx) : base()
        {
            Country = ctx.Countries.Find(countryId).Name;
            CountryId = countryId;
        }

        public string Country { get; set; }
    }
    */
}
