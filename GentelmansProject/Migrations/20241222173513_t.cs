using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GentelmansProject.Migrations
{
    public partial class t : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3f9d0151-eae4-4470-bd38-5f429807cad2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bde0dfaf-1d65-4d32-9637-9c958bcbce9a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bf9ac070-0166-47c5-8774-55a3701ea009");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "26dccfe0-550e-4502-b43c-1aa83939fea0", "d9149aa9-fb00-4a27-a50e-bf4458e9157c", "KULLANCI", "KULLANCI" },
                    { "479c8574-c5a6-45f1-8ae3-5bac5cd7daac", "5478ef7b-cf74-4c2f-89b7-d888e0996167", "ADMIN", "ADMIN" },
                    { "60834832-21dd-453d-947c-e352a59f6f24", "6753e14c-452c-4855-bfd9-79915ad9c231", "BERBER", "BERBER" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "26dccfe0-550e-4502-b43c-1aa83939fea0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "479c8574-c5a6-45f1-8ae3-5bac5cd7daac");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "60834832-21dd-453d-947c-e352a59f6f24");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3f9d0151-eae4-4470-bd38-5f429807cad2", "d3f87a77-cbcc-450b-8657-4c33bc991ea0", "ADMIN", "ADMIN" },
                    { "bde0dfaf-1d65-4d32-9637-9c958bcbce9a", "4832fd25-d174-4b0d-a844-cac47d8b3af8", "BERBER", "BERBER" },
                    { "bf9ac070-0166-47c5-8774-55a3701ea009", "182021ad-54ac-4535-ae1a-526b912c84a2", "KULLANCI", "KULLANCI" }
                });
        }
    }
}
