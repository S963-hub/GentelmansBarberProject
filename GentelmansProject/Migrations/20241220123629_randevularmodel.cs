using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace GentelmansProject.Migrations
{
    public partial class randevularmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kullancis");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44136912-0aa0-491b-b1fc-3f8318be9675");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "86b5372c-faf3-4ce4-ab5a-c5136f6b71c5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a0900ee2-9394-44e1-997e-d723d9dea017");

            migrationBuilder.DropColumn(
                name: "RandevuMusaitlik",
                table: "Randevulars");

            migrationBuilder.DropColumn(
                name: "ServisId",
                table: "Randevulars");

            migrationBuilder.RenameColumn(
                name: "musteriAdi",
                table: "Randevulars",
                newName: "ServisIds");

            migrationBuilder.RenameColumn(
                name: "RandevuTarihiVeSaati",
                table: "Randevulars",
                newName: "RandevuTarihi");

            migrationBuilder.AddColumn<string>(
                name: "KullaniciId",
                table: "Randevulars",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Notlar",
                table: "Randevulars",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "RandevuSaati",
                table: "Randevulars",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "ToplamFiyat",
                table: "Randevulars",
                type: "numeric(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6612624a-bba6-4c2a-9381-5a4eb2da9451", "18ab307c-cd15-4a0b-9cce-77b76d06eeb6", "BERBER", "BERBER" },
                    { "84526ab4-6bc1-4ab1-8e28-d7e811d355c1", "9dccffc6-d7e6-4837-a187-7907eaf8104c", "KULLANCI", "KULLANCI" },
                    { "fb90db82-4f9e-43a8-9d94-e9cab2a81736", "e1a564f7-1c73-4aff-aee8-6a4fcc310ae9", "ADMIN", "ADMIN" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Randevulars_BerberId",
                table: "Randevulars",
                column: "BerberId");

            migrationBuilder.CreateIndex(
                name: "IX_Randevulars_KullaniciId",
                table: "Randevulars",
                column: "KullaniciId");

            migrationBuilder.AddForeignKey(
                name: "FK_Randevulars_AspNetUsers_KullaniciId",
                table: "Randevulars",
                column: "KullaniciId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Randevulars_Berbers_BerberId",
                table: "Randevulars",
                column: "BerberId",
                principalTable: "Berbers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Randevulars_AspNetUsers_KullaniciId",
                table: "Randevulars");

            migrationBuilder.DropForeignKey(
                name: "FK_Randevulars_Berbers_BerberId",
                table: "Randevulars");

            migrationBuilder.DropIndex(
                name: "IX_Randevulars_BerberId",
                table: "Randevulars");

            migrationBuilder.DropIndex(
                name: "IX_Randevulars_KullaniciId",
                table: "Randevulars");

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

            migrationBuilder.DropColumn(
                name: "KullaniciId",
                table: "Randevulars");

            migrationBuilder.DropColumn(
                name: "Notlar",
                table: "Randevulars");

            migrationBuilder.DropColumn(
                name: "RandevuSaati",
                table: "Randevulars");

            migrationBuilder.DropColumn(
                name: "ToplamFiyat",
                table: "Randevulars");

            migrationBuilder.RenameColumn(
                name: "ServisIds",
                table: "Randevulars",
                newName: "musteriAdi");

            migrationBuilder.RenameColumn(
                name: "RandevuTarihi",
                table: "Randevulars",
                newName: "RandevuTarihiVeSaati");

            migrationBuilder.AddColumn<int>(
                name: "RandevuMusaitlik",
                table: "Randevulars",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ServisId",
                table: "Randevulars",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Kullancis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Password = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullancis", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "44136912-0aa0-491b-b1fc-3f8318be9675", "d7746c15-f5de-4e68-9c84-f7e056341dba", "ADMIN", "ADMIN" },
                    { "86b5372c-faf3-4ce4-ab5a-c5136f6b71c5", "982cd3a8-b6fe-4c14-876e-8dc5ec7dc961", "BERBER", "BERBER" },
                    { "a0900ee2-9394-44e1-997e-d723d9dea017", "a1c6ee4e-8a6c-4e78-a45f-dec2aec9ab4a", "KULLANCI", "KULLANCI" }
                });
        }
    }
}
