using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Contact.Microservice.Migrations
{
    public partial class raporentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Rapors",
                columns: table => new
                {
                    UUID = table.Column<Guid>(type: "uuid", nullable: false),
                    Konum = table.Column<string>(type: "text", nullable: false),
                    KisiSayi = table.Column<int>(type: "integer", nullable: false),
                    TelefonNumarasiSayi = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rapors", x => x.UUID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rapors");
        }
    }
}
