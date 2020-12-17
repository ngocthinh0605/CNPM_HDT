using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class mvcPet9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IdNhanVienUserName",
                table: "HoaDons",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_HoaDons_IdNhanVienUserName",
                table: "HoaDons",
                column: "IdNhanVienUserName");

            migrationBuilder.AddForeignKey(
                name: "FK_HoaDons_NhanViens_IdNhanVienUserName",
                table: "HoaDons",
                column: "IdNhanVienUserName",
                principalTable: "NhanViens",
                principalColumn: "UserName",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HoaDons_NhanViens_IdNhanVienUserName",
                table: "HoaDons");

            migrationBuilder.DropIndex(
                name: "IX_HoaDons_IdNhanVienUserName",
                table: "HoaDons");

            migrationBuilder.DropColumn(
                name: "IdNhanVienUserName",
                table: "HoaDons");
        }
    }
}
