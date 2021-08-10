using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebShopReactCore.Migrations
{
    public partial class newDBLayout : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PictureRef = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ISBN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PayDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AuthorBook",
                columns: table => new
                {
                    AuthorsId = table.Column<int>(type: "int", nullable: false),
                    BooksId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthorBook", x => new { x.AuthorsId, x.BooksId });
                    table.ForeignKey(
                        name: "FK_AuthorBook_Authors_AuthorsId",
                        column: x => x.AuthorsId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AuthorBook_Books_BooksId",
                        column: x => x.BooksId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItems_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItems_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "Leena", "Lehtolainen" },
                    { 2, "Caroline", "Säfstrand" },
                    { 3, "Patrick", "Modiano" },
                    { 4, "Maj", "Sjöwall" },
                    { 5, "Per", "Wahlöö" },
                    { 6, "Arnaldur", "Indriðason" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Description", "ISBN", "PictureRef", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "Falska förespeglingar är en spännande och aktuell deckare där Maria Kallio tvingas att ompröva en hel del av det hon tidigare tagit för givet.", "91-0-011026-4", "/Images/falska-förespeglingar.jpg", 50.00m, "Falska förespeglingar" },
                    { 2, "När Elin en dag hittar en förlovningsring i pojkvännen Zacks ficka får hon panik. Hon packar en väska och beger sig brådstörtat till Hallands Väderö - en plats som hon svurit på att aldrig någonsin återvända till. Här får hon dela bostad med Anja, en äldre dam som kommit till ön för att måla. Anja släpper inte gärna någon för nära inpå livet, men när hon ser vilken av hennes tavlor som Elin uppslukas av förstår hon att Elin inte är som alla andra.", "978-91-7475-228-1", "/Images/om-du-bara-visste.jpg", 68.90m, "Om du bara visste" },
                    { 3, "I Nätternas gräs vandrar berättaren Jean genom Paris på spaning efter Dannie, den gåtfulla kvinna han älskade fyrtio år tidigare och som försvann under mystiska omständigheter utan att lämna några spår efter sig. En svart anteckningsbok fullklottrad med namn på personer och platser, med adresser, telefonnummer och tidningsnotiser blir hans hjälp mot glömskan, hans vägvisare till det förgångna.", "978-91-86497-30-9", "/Images/nätternas-gräs.jpg", 175.00m, "Nätternas gräs" },
                    { 5, "En roman om ett brott", "9118220614", "/Images/den-vedervärdige-mannen-från-säffle", 30.00m, "Den vedervärdige mannen från Säffle" },
                    { 6, "Kriminalkommissarie Maria Kallio ser på en direktsänd talk-show om prostitution i teve. Kalabalik utbryter i studion och kamerorna slocknar. Strax därefter ringer Marias mobil: en kvinna har hittats död i tevehuset.     Kvinnan, Lulu Nightingale, är en känd prostituerad med en rad högt uppsatta personer i sin kundkrets. Lulu har dött av cyanidförgiftning strax före sändning och allt tyder på mord. Raden av misstänkta är begränsad eftersom programmet bygger på överraskningsprincipen och bara några få kände till att hon skulle medverka.     Men pusslet blir svårare att lägga än så och Maria Kallio tvingas gång på gång byta spår i utredningen. Finns det någon koppling mellan den mördade Lulu och den svårt sargade och sannolikt prostituerade kvinna som nyligen försvunnit från ett sjukhus? Kan den ryska maffian vara inblandad? Eller finns motivet att hämta i Lulus kundkrets? När en av de misstänkta hittas död  efter vad som ser ut som ett självmord  och tar på sig skulden för mordet på Lulu, blir fallet ännu mer komplicerat. Är det sanningen som vederbörande efterlämnat eller finns det en mördare som inte låter sig stoppas av någon? Maria Kallio, som brottas med ett trängt privatliv och en oförstående chef, står återigen i ett vägskäl i utredningen men blir allt mer övertygad om i vilken riktning hon ska gå  något hon tvingas betala ett högt, personligt pris för.     Liksom i sina tidigare böcker berättar Leena Lehtolainen i Studio Näktergalen om laddade och samtidsrelaterade frågor.", "978-91-0011315-5", "/Images/studio-näktergalen.jpg", 90.00m, "Studio Näktergalen" }
                });

            /*
            migrationBuilder.InsertData(
                table: "AuthorBook",
                columns: new[] { "AuthorsId", "BooksId" },
                values: new object[,]
                {
                    {1, 1 },
                    {2, 2 },
                    {3, 3 },
                    {5, 5 },
                    {6, 5 },
                    {1, 6 }
                });
            */
            migrationBuilder.CreateIndex(
                name: "IX_AuthorBook_BooksId",
                table: "AuthorBook",
                column: "BooksId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_BookId",
                table: "OrderItems",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItems",
                column: "OrderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuthorBook");

            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Orders");
        }
    }
}
