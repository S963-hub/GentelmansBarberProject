using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace GentelmansProject.Migrations
{
    public partial class v : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "57dd66fb-f496-4c82-8f23-87355d0c2df5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7eb783f8-c564-4231-aa46-fc3330874409");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e714fbaf-b38c-46b0-9dae-095c7e3ace8d");

            migrationBuilder.CreateTable(
                name: "Kaydols",
                columns: table => new
                {
                    BerberId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ServisIds = table.Column<string>(type: "text", nullable: false),
                    RandevuTarihi = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    RandevuSaati = table.Column<string>(type: "text", nullable: false),
                    Notlar = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "57dd66fb-f496-4c82-8f23-87355d0c2df5", "92f77871-6df9-42b6-b8f8-962a66f1da5b", "ADMIN", "ADMIN" },
                    { "7eb783f8-c564-4231-aa46-fc3330874409", "777e23e8-b142-4e3c-8b7c-76c3c78a80ff", "KULLANCI", "KULLANCI" },
                    { "e714fbaf-b38c-46b0-9dae-095c7e3ace8d", "abb12cc7-98bd-48a4-b24e-e10000042386", "BERBER", "BERBER" }
                });
        }
    }
}
