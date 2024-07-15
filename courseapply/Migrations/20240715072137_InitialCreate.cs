using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace courseapply.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kurs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    email = table.Column<string>(type: "TEXT", nullable: true),
                    adi = table.Column<string>(type: "TEXT", nullable: true),
                    soyadi = table.Column<string>(type: "TEXT", nullable: true),
                    yasi = table.Column<int>(type: "INTEGER", nullable: true),
                    kayitOlduguTarih = table.Column<DateTime>(type: "TEXT", nullable: true),
                    kursSecimi = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kurs", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kurs");
        }
    }
}
