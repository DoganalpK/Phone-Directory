using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Contact.Microservice.Migrations
{
    public partial class rapordurum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RaporDurumId",
                table: "Rapors",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RaporDurumId",
                table: "Rapors");
        }
    }
}
