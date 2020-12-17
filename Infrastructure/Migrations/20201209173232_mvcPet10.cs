using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class mvcPet10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HoaDons_NhanViens_IdNhanVienUserName",
                table: "HoaDons");

            migrationBuilder.RenameColumn(
                name: "IdNhanVienUserName",
                table: "HoaDons",
                newName: "IdNhanVienUserNameUserName");

            migrationBuilder.RenameIndex(
                name: "IX_HoaDons_IdNhanVienUserName",
                table: "HoaDons",
                newName: "IX_HoaDons_IdNhanVienUserNameUserName");

            migrationBuilder.AddForeignKey(
                name: "FK_HoaDons_NhanViens_IdNhanVienUserNameUserName",
                table: "HoaDons",
                column: "IdNhanVienUserNameUserName",
                principalTable: "NhanViens",
                principalColumn: "UserName",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HoaDons_NhanViens_IdNhanVienUserNameUserName",
                table: "HoaDons");

            migrationBuilder.RenameColumn(
                name: "IdNhanVienUserNameUserName",
                table: "HoaDons",
                newName: "IdNhanVienUserName");

            migrationBuilder.RenameIndex(
                name: "IX_HoaDons_IdNhanVienUserNameUserName",
                table: "HoaDons",
                newName: "IX_HoaDons_IdNhanVienUserName");

            migrationBuilder.AddForeignKey(
                name: "FK_HoaDons_NhanViens_IdNhanVienUserName",
                table: "HoaDons",
                column: "IdNhanVienUserName",
                principalTable: "NhanViens",
                principalColumn: "UserName",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
