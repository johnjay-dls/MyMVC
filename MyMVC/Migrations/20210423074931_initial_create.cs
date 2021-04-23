using Microsoft.EntityFrameworkCore.Migrations;

namespace MyFirstMVC.Migrations
{
    public partial class initial_create : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PersonModel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Lastname = table.Column<string>(maxLength: 200, nullable: true),
                    Age = table.Column<int>(nullable: false),
                    Email = table.Column<string>(maxLength: 200, nullable: false),
                    Contactnumber = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    Confirmpassword = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonModel", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PersonModel");
        }
    }
}
