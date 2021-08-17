using Microsoft.EntityFrameworkCore.Migrations;

namespace AdoteUmPet.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pet",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Tipo = table.Column<string>(nullable: false),
                    Raca = table.Column<string>(nullable: false),
                    Idade = table.Column<int>(nullable: false),
                    Porte = table.Column<string>(nullable: false),
                    Peso = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pet", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pet");
        }
    }
}
