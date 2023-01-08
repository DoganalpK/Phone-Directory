using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Contact.Microservice.Migrations
{
    public partial class IletisimBilgileris : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IletisimBilgileri_Kisiler_KisilerUUID",
                table: "IletisimBilgileri");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IletisimBilgileri",
                table: "IletisimBilgileri");

            migrationBuilder.RenameTable(
                name: "IletisimBilgileri",
                newName: "IletisimBilgileris");

            migrationBuilder.RenameIndex(
                name: "IX_IletisimBilgileri_KisilerUUID",
                table: "IletisimBilgileris",
                newName: "IX_IletisimBilgileris_KisilerUUID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_IletisimBilgileris",
                table: "IletisimBilgileris",
                column: "UUID");

            migrationBuilder.AddForeignKey(
                name: "FK_IletisimBilgileris_Kisiler_KisilerUUID",
                table: "IletisimBilgileris",
                column: "KisilerUUID",
                principalTable: "Kisiler",
                principalColumn: "UUID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IletisimBilgileris_Kisiler_KisilerUUID",
                table: "IletisimBilgileris");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IletisimBilgileris",
                table: "IletisimBilgileris");

            migrationBuilder.RenameTable(
                name: "IletisimBilgileris",
                newName: "IletisimBilgileri");

            migrationBuilder.RenameIndex(
                name: "IX_IletisimBilgileris_KisilerUUID",
                table: "IletisimBilgileri",
                newName: "IX_IletisimBilgileri_KisilerUUID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_IletisimBilgileri",
                table: "IletisimBilgileri",
                column: "UUID");

            migrationBuilder.AddForeignKey(
                name: "FK_IletisimBilgileri_Kisiler_KisilerUUID",
                table: "IletisimBilgileri",
                column: "KisilerUUID",
                principalTable: "Kisiler",
                principalColumn: "UUID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
