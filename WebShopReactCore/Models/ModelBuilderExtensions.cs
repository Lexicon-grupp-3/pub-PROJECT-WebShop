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
                },
                new Author
                {
                    Id = 4,
                    FirstName = "Maj",
                    LastName = "Sjöwall"
                },
                new Author
                {
                    Id = 5,
                    FirstName = "Per",
                    LastName = "Wahlöö"
                },
                new Author
                {
                    Id = 6,
                    FirstName = "Arnaldur",
                    LastName = "Indriðason"
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
                },
                new Book
                {
                    Id = 5,
                    Title = "Den vedervärdige mannen från Säffle",
                    Description = "En roman om ett brott",
                    PictureRef = "/Images/den-vedervärdige-mannen-från-säffle",
                    ISBN = "9118220614",
                    Price = 30.00M
                },
                new Book
                {
                    Id = 6,
                    Title = "Studio Näktergalen",
                    Description = "Kriminalkommissarie Maria Kallio ser på en direktsänd talk-show om prostitution i teve. Kalabalik utbryter i studion och kamerorna slocknar. Strax därefter ringer Marias mobil: en kvinna har hittats död i tevehuset.     Kvinnan, Lulu Nightingale, är en känd prostituerad med en rad högt uppsatta personer i sin kundkrets. Lulu har dött av cyanidförgiftning strax före sändning och allt tyder på mord. Raden av misstänkta är begränsad eftersom programmet bygger på överraskningsprincipen och bara några få kände till att hon skulle medverka.     Men pusslet blir svårare att lägga än så och Maria Kallio tvingas gång på gång byta spår i utredningen. Finns det någon koppling mellan den mördade Lulu och den svårt sargade och sannolikt prostituerade kvinna som nyligen försvunnit från ett sjukhus? Kan den ryska maffian vara inblandad? Eller finns motivet att hämta i Lulus kundkrets? När en av de misstänkta hittas död  efter vad som ser ut som ett självmord  och tar på sig skulden för mordet på Lulu, blir fallet ännu mer komplicerat. Är det sanningen som vederbörande efterlämnat eller finns det en mördare som inte låter sig stoppas av någon? Maria Kallio, som brottas med ett trängt privatliv och en oförstående chef, står återigen i ett vägskäl i utredningen men blir allt mer övertygad om i vilken riktning hon ska gå  något hon tvingas betala ett högt, personligt pris för.     Liksom i sina tidigare böcker berättar Leena Lehtolainen i Studio Näktergalen om laddade och samtidsrelaterade frågor.",
                    PictureRef = "/Images/studio-näktergalen.jpg",
                    ISBN = "978-91-0011315-5",
                    Price = 90.00M
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
                },
                new AuthorBook
                {
                    AuthorId = 5,
                    BookId = 5
                },
                new AuthorBook
                {
                    AuthorId = 6,
                    BookId = 5
                },
                new AuthorBook
                {
                    AuthorId = 1,
                    BookId = 6
                }
            );
        }
    }
}
