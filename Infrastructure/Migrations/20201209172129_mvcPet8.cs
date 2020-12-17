using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class mvcPet8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HoaDons_KhachHangs_IdKhachHangUserName",
                table: "HoaDons");

            migrationBuilder.DropForeignKey(
                name: "FK_HoaDons_NhanViens_IdNhanVienUserName",
                table: "HoaDons");

            migrationBuilder.DropIndex(
                name: "IX_HoaDons_IdKhachHangUserName",
                table: "HoaDons");

            migrationBuilder.DropIndex(
                name: "IX_HoaDons_IdNhanVienUserName",
                table: "HoaDons");

            migrationBuilder.DropColumn(
                name: "IdNhanVienUserName",
                table: "HoaDons");

            migrationBuilder.AlterColumn<string>(
                name: "GioiTinh",
                table: "NhanViens",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(5)",
                oldMaxLength: 5);

            migrationBuilder.AlterColumn<string>(
                name: "GioiTinh",
                table: "KhachHangs",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(5)",
                oldMaxLength: 5);

            migrationBuilder.AlterColumn<string>(
                name: "IdKhachHangUserName",
                table: "HoaDons",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    CartId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    _thucungIdThuCung = table.Column<int>(type: "int", nullable: true),
                    _Quantity = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.CartId);
                    table.ForeignKey(
                        name: "FK_Carts_KhachHangs_UserName",
                        column: x => x.UserName,
                        principalTable: "KhachHangs",
                        principalColumn: "UserName",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Carts_thuCungs__thucungIdThuCung",
                        column: x => x._thucungIdThuCung,
                        principalTable: "thuCungs",
                        principalColumn: "IdThuCung",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Carts__thucungIdThuCung",
                table: "Carts",
                column: "_thucungIdThuCung");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_UserName",
                table: "Carts",
                column: "UserName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.AlterColumn<string>(
                name: "GioiTinh",
                table: "NhanViens",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "GioiTinh",
                table: "KhachHangs",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "IdKhachHangUserName",
                table: "HoaDons",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IdNhanVienUserName",
                table: "HoaDons",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_HoaDons_IdKhachHangUserName",
                table: "HoaDons",
                column: "IdKhachHangUserName");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDons_IdNhanVienUserName",
                table: "HoaDons",
                column: "IdNhanVienUserName");

            migrationBuilder.AddForeignKey(
                name: "FK_HoaDons_KhachHangs_IdKhachHangUserName",
                table: "HoaDons",
                column: "IdKhachHangUserName",
                principalTable: "KhachHangs",
                principalColumn: "UserName",
                onDelete: ReferentialAction.Restrict);

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
