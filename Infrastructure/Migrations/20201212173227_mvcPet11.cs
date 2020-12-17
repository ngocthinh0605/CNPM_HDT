using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class mvcPet11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carts_KhachHangs_UserName",
                table: "Carts");

            migrationBuilder.DropForeignKey(
                name: "FK_Carts_thuCungs__thucungIdThuCung",
                table: "Carts");

            migrationBuilder.DropForeignKey(
                name: "FK_HoaDons_NhanViens_IdNhanVienUserNameUserName",
                table: "HoaDons");

            migrationBuilder.DropIndex(
                name: "IX_HoaDons_IdNhanVienUserNameUserName",
                table: "HoaDons");

            migrationBuilder.DropIndex(
                name: "IX_Carts__thucungIdThuCung",
                table: "Carts");

            migrationBuilder.DropIndex(
                name: "IX_Carts_UserName",
                table: "Carts");

            migrationBuilder.DropColumn(
                name: "IdNhanVienUserNameUserName",
                table: "HoaDons");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Carts");

            migrationBuilder.DropColumn(
                name: "_thucungIdThuCung",
                table: "Carts");

            migrationBuilder.RenameColumn(
                name: "_Quantity",
                table: "Carts",
                newName: "TinhTrang");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Carts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Carts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "User",
                table: "Carts",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Id",
                table: "Carts");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Carts");

            migrationBuilder.DropColumn(
                name: "User",
                table: "Carts");

            migrationBuilder.RenameColumn(
                name: "TinhTrang",
                table: "Carts",
                newName: "_Quantity");

            migrationBuilder.AddColumn<string>(
                name: "IdNhanVienUserNameUserName",
                table: "HoaDons",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Carts",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "_thucungIdThuCung",
                table: "Carts",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_HoaDons_IdNhanVienUserNameUserName",
                table: "HoaDons",
                column: "IdNhanVienUserNameUserName");

            migrationBuilder.CreateIndex(
                name: "IX_Carts__thucungIdThuCung",
                table: "Carts",
                column: "_thucungIdThuCung");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_UserName",
                table: "Carts",
                column: "UserName");

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_KhachHangs_UserName",
                table: "Carts",
                column: "UserName",
                principalTable: "KhachHangs",
                principalColumn: "UserName",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_thuCungs__thucungIdThuCung",
                table: "Carts",
                column: "_thucungIdThuCung",
                principalTable: "thuCungs",
                principalColumn: "IdThuCung",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HoaDons_NhanViens_IdNhanVienUserNameUserName",
                table: "HoaDons",
                column: "IdNhanVienUserNameUserName",
                principalTable: "NhanViens",
                principalColumn: "UserName",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
