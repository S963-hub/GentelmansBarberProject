using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GentelmansProject.Migrations
{
    public partial class randevularimmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6612624a-bba6-4c2a-9381-5a4eb2da9451");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "84526ab4-6bc1-4ab1-8e28-d7e811d355c1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fb90db82-4f9e-43a8-9d94-e9cab2a81736");

            migrationBuilder.CreateTable(
                name: "Randevularim",
                columns: table => new
                {
                    UserID = table.Column<string>(type: "text", nullable: false),
                    BerberAdi = table.Column<string>(type: "text", nullable: false),
                    Servisler = table.Column<string>(type: "text", nullable: false),
                    Tarih = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Saat = table.Column<string>(type: "text", nullable: false),
                    ToplamFiyat = table.Column<decimal>(type: "numeric", nullable: false),
                    Notlar = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Randevularim", x => x.UserID);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1e452643-351c-41d4-a04b-bcf56700b5f5", "ee8369ac-dae6-47c8-8a12-5c22140a6f2f", "BERBER", "BERBER" },
                    { "72080bbf-bc76-4402-853b-240f420320af", "1c168112-8a4b-43e6-b6e3-73f493571211", "KULLANCI", "KULLANCI" },
                    { "c1625b35-1c11-4052-ac7c-08abe137eea5", "b613a10b-4838-434a-8a87-38454369c782", "ADMIN", "ADMIN" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Randevularim");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1e452643-351c-41d4-a04b-bcf56700b5f5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "72080bbf-bc76-4402-853b-240f420320af");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c1625b35-1c11-4052-ac7c-08abe137eea5");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6612624a-bba6-4c2a-9381-5a4eb2da9451", "18ab307c-cd15-4a0b-9cce-77b76d06eeb6", "BERBER", "BERBER" },
                    { "84526ab4-6bc1-4ab1-8e28-d7e811d355c1", "9dccffc6-d7e6-4837-a187-7907eaf8104c", "KULLANCI", "KULLANCI" },
                    { "fb90db82-4f9e-43a8-9d94-e9cab2a81736", "e1a564f7-1c73-4aff-aee8-6a4fcc310ae9", "ADMIN", "ADMIN" }
                });
        }
    }
}
