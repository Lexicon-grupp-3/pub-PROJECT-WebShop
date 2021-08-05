using Microsoft.EntityFrameworkCore.Migrations;

namespace WebShopReactCore.Migrations
{
    public partial class AuthorBookClasschangedaddedkey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 4, "Maj", "Sjöwall" },
                    { 5, "Per", "Wahlöö" },
                    { 6, "Arnaldur", "Indriðason" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Description", "ISBN", "PictureRef", "Price", "Title" },
                values: new object[,]
                {
                    { 5, "En roman om ett brott", "9118220614", "/Images/den-vedervärdige-mannen-från-säffle", 30.00m, "Den vedervärdige mannen från Säffle" },
                    { 6, "Kriminalkommissarie Maria Kallio ser på en direktsänd talk-show om prostitution i teve. Kalabalik utbryter i studion och kamerorna slocknar. Strax därefter ringer Marias mobil: en kvinna har hittats död i tevehuset.     Kvinnan, Lulu Nightingale, är en känd prostituerad med en rad högt uppsatta personer i sin kundkrets. Lulu har dött av cyanidförgiftning strax före sändning och allt tyder på mord. Raden av misstänkta är begränsad eftersom programmet bygger på överraskningsprincipen och bara några få kände till att hon skulle medverka.     Men pusslet blir svårare att lägga än så och Maria Kallio tvingas gång på gång byta spår i utredningen. Finns det någon koppling mellan den mördade Lulu och den svårt sargade och sannolikt prostituerade kvinna som nyligen försvunnit från ett sjukhus? Kan den ryska maffian vara inblandad? Eller finns motivet att hämta i Lulus kundkrets? När en av de misstänkta hittas död  efter vad som ser ut som ett självmord  och tar på sig skulden för mordet på Lulu, blir fallet ännu mer komplicerat. Är det sanningen som vederbörande efterlämnat eller finns det en mördare som inte låter sig stoppas av någon? Maria Kallio, som brottas med ett trängt privatliv och en oförstående chef, står återigen i ett vägskäl i utredningen men blir allt mer övertygad om i vilken riktning hon ska gå  något hon tvingas betala ett högt, personligt pris för.     Liksom i sina tidigare böcker berättar Leena Lehtolainen i Studio Näktergalen om laddade och samtidsrelaterade frågor.", "978-91-0011315-5", "/Images/studio-näktergalen.jpg", 90.00m, "Studio Näktergalen" }
                });

            migrationBuilder.InsertData(
                table: "AuthorBooks",
                columns: new[] { "AuthorId", "BookId" },
                values: new object[] { 5, 5 });

            migrationBuilder.InsertData(
                table: "AuthorBooks",
                columns: new[] { "AuthorId", "BookId" },
                values: new object[] { 6, 5 });

            migrationBuilder.InsertData(
                table: "AuthorBooks",
                columns: new[] { "AuthorId", "BookId" },
                values: new object[] { 1, 6 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AuthorBooks",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 1, 6 });

            migrationBuilder.DeleteData(
                table: "AuthorBooks",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "AuthorBooks",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 6, 5 });

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
