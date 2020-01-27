using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryApi.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 200, nullable: true),
                    Author = table.Column<string>(maxLength: 200, nullable: true),
                    Genre = table.Column<string>(nullable: true),
                    NumberOfPages = table.Column<int>(nullable: false),
                    InInventory = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "Genre", "InInventory", "NumberOfPages", "Title" },
                values: new object[] { 1, "Threau", "Philosophy", true, 322, "Walden" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "Genre", "InInventory", "NumberOfPages", "Title" },
                values: new object[] { 2, "DJ Spooky That Subliminal Kid", "Music", true, 180, "Rythm Science" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "Genre", "InInventory", "NumberOfPages", "Title" },
                values: new object[] { 3, "Emerson", "Philosophy", true, 182, "Nature" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
