using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class mvcPet5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MyProperty",
                table: "thuCungs",
                newName: "parentID");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "thuCungs",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "thuCungs");

            migrationBuilder.RenameColumn(
                name: "parentID",
                table: "thuCungs",
                newName: "MyProperty");
        }
    }
}
