using Microsoft.EntityFrameworkCore.Migrations;

namespace WebShopReactCore.Migrations
{
    public partial class author2_book2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuthorBooks");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3);

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

            migrationBuilder.CreateIndex(
                name: "IX_AuthorBook_BooksId",
                table: "AuthorBook",
                column: "BooksId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuthorBook");

            migrationBuilder.CreateTable(
                name: "AuthorBooks",
                columns: table => new
                {
                    AuthorId = table.Column<int>(type: "int", nullable: false),
                    BookId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthorBooks", x => new { x.AuthorId, x.BookId });
                    table.ForeignKey(
                        name: "FK_AuthorBooks_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AuthorBooks_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
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
                    { 3, "Patrick", "Modiano" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Description", "ISBN", "PictureRef", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "Falska förespeglingar är en spännande och aktuell deckare där Maria Kallio tvingas att ompröva en hel del av det hon tidigare tagit för givet.", "91-0-011026-4", "/Images/falska-förespeglingar.jpg", 50.00m, "Falska förespeglingar" },
                    { 2, "När Elin en dag hittar en förlovningsring i pojkvännen Zacks ficka får hon panik. Hon packar en väska och beger sig brådstörtat till Hallands Väderö - en plats som hon svurit på att aldrig någonsin återvända till. Här får hon dela bostad med Anja, en äldre dam som kommit till ön för att måla. Anja släpper inte gärna någon för nära inpå livet, men när hon ser vilken av hennes tavlor som Elin uppslukas av förstår hon att Elin inte är som alla andra.", "978-91-7475-228-1", "/Images/om-du-bara-visste.jpg", 68.90m, "Om du bara visste" },
                    { 3, "I Nätternas gräs vandrar berättaren Jean genom Paris på spaning efter Dannie, den gåtfulla kvinna han älskade fyrtio år tidigare och som försvann under mystiska omständigheter utan att lämna några spår efter sig. En svart anteckningsbok fullklottrad med namn på personer och platser, med adresser, telefonnummer och tidningsnotiser blir hans hjälp mot glömskan, hans vägvisare till det förgångna.", "978-91-86497-30-9", "/Images/nätternas-gräs.jpg", 175.00m, "Nätternas gräs" }
                });

            migrationBuilder.InsertData(
                table: "AuthorBooks",
                columns: new[] { "AuthorId", "BookId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "AuthorBooks",
                columns: new[] { "AuthorId", "BookId" },
                values: new object[] { 2, 2 });

            migrationBuilder.InsertData(
                table: "AuthorBooks",
                columns: new[] { "AuthorId", "BookId" },
                values: new object[] { 3, 3 });

            migrationBuilder.CreateIndex(
                name: "IX_AuthorBooks_BookId",
                table: "AuthorBooks",
                column: "BookId");
        }
    }
}
