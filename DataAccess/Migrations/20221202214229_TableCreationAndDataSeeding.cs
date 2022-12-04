using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class TableCreationAndDataSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Occupations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OccupationName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rating = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Factor = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Occupations", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Occupations",
                columns: new[] { "Id", "Factor", "OccupationName", "Rating" },
                values: new object[,]
                {
                    { 1, 1.5, "Cleaner", "Light Manual" },
                    { 2, 1.0, "Doctor", "Professional" },
                    { 3, 1.25, "Author", "White Collar" },
                    { 4, 1.75, "Farmer", "Heavy Manual" },
                    { 5, 1.75, "Mechanic", "Heavy Manual" },
                    { 6, 1.5, "Florist", "Light Manual" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Occupations");
        }
    }
}
