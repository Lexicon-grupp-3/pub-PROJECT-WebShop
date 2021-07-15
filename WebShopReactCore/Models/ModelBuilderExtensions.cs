using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebShopReactCore.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().HasData(
                new Author
                {
                    Id = 1,
                    FirstName = "Leena",
                    LastName = "Lehtolainen"
                },
                new Author
                {
                    Id = 2,
                    FirstName = "Caroline",
                    LastName = "Säfstrand"
                },
                new Author
                {
                    Id = 3,
                    FirstName = "Patrick",
                    LastName = "Modiano"
                }
            );
            modelBuilder.Entity<Book>().HasData(
                new Book
                {
                    Id = 1,
                    Title = "Falska förespeglingar",
                    Description = "Falska förespeglingar är en spännande och aktuell deckare där Maria Kallio tvingas att ompröva en hel del av det hon tidigare tagit för givet.",
                    PictureRef = "/Images/falska-förespeglingar.jpg",
                    ISBN = "91-0-011026-4",
                    Price = 50.00M
                },
                new Book
                {
                    Id = 2,
                    Title = "Om du bara visste",
                    Description = "När Elin en dag hittar en förlovningsring i pojkvännen Zacks ficka får hon panik. Hon packar en väska och beger sig brådstörtat till Hallands Väderö - en plats som hon svurit på att aldrig någonsin återvända till. Här får hon dela bostad med Anja, en äldre dam som kommit till ön för att måla. Anja släpper inte gärna någon för nära inpå livet, men när hon ser vilken av hennes tavlor som Elin uppslukas av förstår hon att Elin inte är som alla andra.",
                    PictureRef = "/Images/om-du-bara-visste.jpg",
                    ISBN = "978-91-7475-228-1",
                    Price = 68.90M
                },
                new Book
                {
                    Id = 3,
                    Title = "Nätternas gräs",
                    Description = "I Nätternas gräs vandrar berättaren Jean genom Paris på spaning efter Dannie, den gåtfulla kvinna han älskade fyrtio år tidigare och som försvann under mystiska omständigheter utan att lämna några spår efter sig. En svart anteckningsbok fullklottrad med namn på personer och platser, med adresser, telefonnummer och tidningsnotiser blir hans hjälp mot glömskan, hans vägvisare till det förgångna.",
                    PictureRef = "/Images/nätternas-gräs.jpg",
                    ISBN = "978-91-86497-30-9",
                    Price = 175.00M
                }
            );
            modelBuilder.Entity<AuthorBook>().HasData(
                new AuthorBook
                {
                    AuthorId = 1,
                    BookId = 1
                },
                new AuthorBook
                {
                    AuthorId = 2,
                    BookId = 2
                },
                new AuthorBook
                {
                    AuthorId = 3,
                    BookId = 3
                }
            );
        }
    }
}
