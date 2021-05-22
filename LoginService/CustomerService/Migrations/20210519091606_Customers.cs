using Microsoft.EntityFrameworkCore.Migrations;

namespace CustomerService.Migrations
{
    public partial class Customers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "customers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Birthdate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customers", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "customers",
                columns: new[] { "ID", "Birthdate", "City", "ContactNo", "Email", "FullName", "Gender" },
                values: new object[] { 1, "20-01-1990", "Ahemdabad", "9090909090", "saloni@gmail.com", "Saloni", "Female" });

            migrationBuilder.InsertData(
                table: "customers",
                columns: new[] { "ID", "Birthdate", "City", "ContactNo", "Email", "FullName", "Gender" },
                values: new object[] { 2, "2-11-1980", "Navsari", "9078609090", "Ram@gmail.com", "Ram", "Male" });

            migrationBuilder.InsertData(
                table: "customers",
                columns: new[] { "ID", "Birthdate", "City", "ContactNo", "Email", "FullName", "Gender" },
                values: new object[] { 3, "12-08-1980", "Mandsaur", "9897654450", "Nayan@gmail.com", "Nayan", "Male" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "customers");
        }
    }
}
