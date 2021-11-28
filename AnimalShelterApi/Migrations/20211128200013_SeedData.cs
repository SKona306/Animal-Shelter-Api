using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalShelterApi.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "Age", "Backstory", "Gender", "Name", "Species" },
                values: new object[,]
                {
                    { 1, 1, "Born recently with many siblings", "Female", "Spark", "Dog" },
                    { 2, 2, "Raised by foster family", "Male", "Boots", "Cat" },
                    { 3, 7, "Raised to believe she is a husky", "Female", "Charlie", "Dog" },
                    { 4, 5, "Found running the streets of Portland", "Female", "Kona", "Cat" },
                    { 5, 3, "Very generic Name not so generic puppy", "Male", "Bob", "Dog" },
                    { 6, 9, "Saved from a traveling circus", "Female", "Kyro", "Bird" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 6);
        }
    }
}
