using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication4.Data.Migrations
{
    public partial class berbers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "berbers");

            migrationBuilder.RenameTable(
                name: "Randevum",
                newName: "Randevum",
                newSchema: "berbers");

            migrationBuilder.RenameTable(
                name: "Kategoris",
                newName: "Kategoris",
                newSchema: "berbers");

            migrationBuilder.RenameTable(
                name: "AspNetUserTokens",
                newName: "AspNetUserTokens",
                newSchema: "berbers");

            migrationBuilder.RenameTable(
                name: "AspNetUsers",
                newName: "AspNetUsers",
                newSchema: "berbers");

            migrationBuilder.RenameTable(
                name: "AspNetUserRoles",
                newName: "AspNetUserRoles",
                newSchema: "berbers");

            migrationBuilder.RenameTable(
                name: "AspNetUserLogins",
                newName: "AspNetUserLogins",
                newSchema: "berbers");

            migrationBuilder.RenameTable(
                name: "AspNetUserClaims",
                newName: "AspNetUserClaims",
                newSchema: "berbers");

            migrationBuilder.RenameTable(
                name: "AspNetRoles",
                newName: "AspNetRoles",
                newSchema: "berbers");

            migrationBuilder.RenameTable(
                name: "AspNetRoleClaims",
                newName: "AspNetRoleClaims",
                newSchema: "berbers");

            migrationBuilder.CreateTable(
                name: "berbers",
                schema: "berbers",
                columns: table => new
                {
                    BerberId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DukkanAdi = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_berbers", x => x.BerberId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "berbers",
                schema: "berbers");

            migrationBuilder.RenameTable(
                name: "Randevum",
                schema: "berbers",
                newName: "Randevum");

            migrationBuilder.RenameTable(
                name: "Kategoris",
                schema: "berbers",
                newName: "Kategoris");

            migrationBuilder.RenameTable(
                name: "AspNetUserTokens",
                schema: "berbers",
                newName: "AspNetUserTokens");

            migrationBuilder.RenameTable(
                name: "AspNetUsers",
                schema: "berbers",
                newName: "AspNetUsers");

            migrationBuilder.RenameTable(
                name: "AspNetUserRoles",
                schema: "berbers",
                newName: "AspNetUserRoles");

            migrationBuilder.RenameTable(
                name: "AspNetUserLogins",
                schema: "berbers",
                newName: "AspNetUserLogins");

            migrationBuilder.RenameTable(
                name: "AspNetUserClaims",
                schema: "berbers",
                newName: "AspNetUserClaims");

            migrationBuilder.RenameTable(
                name: "AspNetRoles",
                schema: "berbers",
                newName: "AspNetRoles");

            migrationBuilder.RenameTable(
                name: "AspNetRoleClaims",
                schema: "berbers",
                newName: "AspNetRoleClaims");
        }
    }
}
