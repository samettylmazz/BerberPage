using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication4.Data.Migrations
{
    public partial class sonuc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ImageName",
                table: "Kategoris",
                type: "nvarchar(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Randevum",
                columns: table => new
                {
                    RandevuId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    İstekleriniz = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KategoriId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Randevum", x => x.RandevuId);
                    table.ForeignKey(
                        name: "FK_Randevum_Kategoris_KategoriId",
                        column: x => x.KategoriId,
                        principalTable: "Kategoris",
                        principalColumn: "KategoriId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Randevum_KategoriId",
                table: "Randevum",
                column: "KategoriId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Randevum");

            migrationBuilder.AlterColumn<string>(
                name: "ImageName",
                table: "Kategoris",
                type: "nvarchar(40)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldNullable: true);
        }
    }
}
