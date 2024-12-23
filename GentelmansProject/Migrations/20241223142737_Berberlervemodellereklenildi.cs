using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace GentelmansProject.Migrations
{
    public partial class Berberlervemodellereklenildi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kaydols");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c8f48989-3c55-4fb4-8e65-d1db55d9d2cf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d3b7364a-5d98-4139-8f88-37cda3cf1ee2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d9697045-6352-44d6-bfaf-9d5002cc6908");

            migrationBuilder.DropColumn(
                name: "musaitlik",
                table: "Berbers");

            migrationBuilder.CreateTable(
                name: "Berbers2",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    UzmanlikAlani = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Berbers2", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Berbers3",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    UzmanlikAlani = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Berbers3", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Servises2",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    HizmetSuresi = table.Column<int>(type: "integer", nullable: false),
                    HizmetFiyat = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servises2", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Servises3",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    HizmetSuresi = table.Column<int>(type: "integer", nullable: false),
                    HizmetFiyat = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servises3", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "098ccb60-c714-40d2-983c-22f19e836512", "f6acc6e9-5aca-497e-af0c-450b2cf70078", "ADMIN", "ADMIN" },
                    { "5c6583ca-1622-4b1e-974c-3f82fdda9f84", "c1a2419a-7b33-491f-97cb-e8ae2c9a8ae8", "KULLANCI", "KULLANCI" },
                    { "9de7daf1-c28b-4b6d-b33f-148497f39c85", "f921d70e-d4fa-4d45-8693-28186137ed3d", "BERBER", "BERBER" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Berbers2");

            migrationBuilder.DropTable(
                name: "Berbers3");

            migrationBuilder.DropTable(
                name: "Servises2");

            migrationBuilder.DropTable(
                name: "Servises3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "098ccb60-c714-40d2-983c-22f19e836512");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5c6583ca-1622-4b1e-974c-3f82fdda9f84");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9de7daf1-c28b-4b6d-b33f-148497f39c85");

            migrationBuilder.AddColumn<int>(
                name: "musaitlik",
                table: "Berbers",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Kaydols",
                columns: table => new
                {
                    BerberId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Notlar = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    RandevuSaati = table.Column<string>(type: "text", nullable: false),
                    RandevuTarihi = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ServisIds = table.Column<string>(type: "text", nullable: false),
                    ToplamFiyat = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kaydols", x => x.BerberId);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "c8f48989-3c55-4fb4-8e65-d1db55d9d2cf", "feb04410-7335-4539-95b1-f95149bff378", "ADMIN", "ADMIN" },
                    { "d3b7364a-5d98-4139-8f88-37cda3cf1ee2", "fd0f3f03-7b0b-4124-9c9e-e492da06ff3e", "BERBER", "BERBER" },
                    { "d9697045-6352-44d6-bfaf-9d5002cc6908", "6b335f24-47c9-4f67-8d11-e98e11362e82", "KULLANCI", "KULLANCI" }
                });
        }
    }
}
