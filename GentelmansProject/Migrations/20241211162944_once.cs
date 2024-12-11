using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace GentelmansProject.Migrations
{
    public partial class once : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Berbers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    UzmanlikAlani = table.Column<string>(type: "text", nullable: false),
                    musaitlik = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Berbers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kullancis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Password = table.Column<string>(type: "text", nullable: false),
                    CreateData = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullancis", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Randevulars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    musteriAdi = table.Column<string>(type: "text", nullable: false),
                    ServisId = table.Column<int>(type: "integer", nullable: false),
                    BerberId = table.Column<int>(type: "integer", nullable: false),
                    RandevuTarihiVeSaati = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    RandevuMusaitlik = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Randevulars", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Servises",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    HizmetSuresi = table.Column<int>(type: "integer", nullable: false),
                    HizmetFiyat = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servises", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Berbers");

            migrationBuilder.DropTable(
                name: "Kullancis");

            migrationBuilder.DropTable(
                name: "Randevulars");

            migrationBuilder.DropTable(
                name: "Servises");
        }
    }
}
