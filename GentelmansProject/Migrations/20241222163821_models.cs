using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GentelmansProject.Migrations
{
    public partial class models : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Randevulars_AspNetUsers_KullaniciId",
                table: "Randevulars");

            migrationBuilder.DropIndex(
                name: "IX_Randevulars_KullaniciId",
                table: "Randevulars");

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
                    { "8d428609-40c3-4dad-a0b6-5299b1ef6f46", "15872da6-51e5-44b0-8a11-57c9f6c1b496", "KULLANCI", "KULLANCI" },
                    { "bcd3ac26-2d68-4a8b-87d0-555dc44492d4", "1245733e-fa5d-4879-a468-391f59ed58b5", "BERBER", "BERBER" },
                    { "cfe9cc14-9e6a-4dee-b985-91138019a0df", "08ddba97-e2b9-4a78-bb12-1dd3a504e218", "ADMIN", "ADMIN" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8d428609-40c3-4dad-a0b6-5299b1ef6f46");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bcd3ac26-2d68-4a8b-87d0-555dc44492d4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cfe9cc14-9e6a-4dee-b985-91138019a0df");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1e452643-351c-41d4-a04b-bcf56700b5f5", "ee8369ac-dae6-47c8-8a12-5c22140a6f2f", "BERBER", "BERBER" },
                    { "72080bbf-bc76-4402-853b-240f420320af", "1c168112-8a4b-43e6-b6e3-73f493571211", "KULLANCI", "KULLANCI" },
                    { "c1625b35-1c11-4052-ac7c-08abe137eea5", "b613a10b-4838-434a-8a87-38454369c782", "ADMIN", "ADMIN" }
                });

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
        }
    }
}
