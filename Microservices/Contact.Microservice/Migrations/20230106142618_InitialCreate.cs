using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Contact.Microservice.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kisiler",
                columns: table => new
                {
                    UUID = table.Column<Guid>(type: "uuid", nullable: false),
                    Ad = table.Column<string>(type: "character varying(64)", maxLength: 64, nullable: true),
                    Soyad = table.Column<string>(type: "character varying(64)", maxLength: 64, nullable: true),
                    Firma = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kisiler", x => x.UUID);
                });

            migrationBuilder.CreateTable(
                name: "IletisimBilgileri",
                columns: table => new
                {
                    UUID = table.Column<Guid>(type: "uuid", nullable: false),
                    BilgiIcerigi = table.Column<string>(type: "text", nullable: true),
                    TelefonNumarasi = table.Column<string>(type: "text", nullable: true),
                    EmailAdresi = table.Column<string>(type: "text", nullable: true),
                    Konum = table.Column<string>(type: "text", nullable: true),
                    KisilerUUID = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IletisimBilgileri", x => x.UUID);
                    table.ForeignKey(
                        name: "FK_IletisimBilgileri_Kisiler_KisilerUUID",
                        column: x => x.KisilerUUID,
                        principalTable: "Kisiler",
                        principalColumn: "UUID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IletisimBilgileri_KisilerUUID",
                table: "IletisimBilgileri",
                column: "KisilerUUID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IletisimBilgileri");

            migrationBuilder.DropTable(
                name: "Kisiler");
        }
    }
}
