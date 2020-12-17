using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class mvcPet12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietHoaDons_HoaDons_IdHoaDon1",
                table: "ChiTietHoaDons");

            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietHoaDons_thuCungs_IdThuCung1",
                table: "ChiTietHoaDons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ChiTietHoaDons",
                table: "ChiTietHoaDons");

            migrationBuilder.DropIndex(
                name: "IX_ChiTietHoaDons_IdHoaDon1",
                table: "ChiTietHoaDons");

            migrationBuilder.DropIndex(
                name: "IX_ChiTietHoaDons_IdThuCung1",
                table: "ChiTietHoaDons");

            migrationBuilder.DropColumn(
                name: "TinhTrang",
                table: "Carts");

            migrationBuilder.DropColumn(
                name: "IdHoaDon1",
                table: "ChiTietHoaDons");

            migrationBuilder.DropColumn(
                name: "IdThuCung1",
                table: "ChiTietHoaDons");

            migrationBuilder.RenameTable(
                name: "ChiTietHoaDons",
                newName: "ChiTietHoaDon");

            migrationBuilder.AddColumn<int>(
                name: "IdTrangThai",
                table: "HoaDons",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdHoaDon",
                table: "ChiTietHoaDon",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdThuCung",
                table: "ChiTietHoaDon",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SoLuong",
                table: "ChiTietHoaDon",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<float>(
                name: "ThanhTien",
                table: "ChiTietHoaDon",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ChiTietHoaDon",
                table: "ChiTietHoaDon",
                column: "IdChiTietHD");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ChiTietHoaDon",
                table: "ChiTietHoaDon");

            migrationBuilder.DropColumn(
                name: "IdTrangThai",
                table: "HoaDons");

            migrationBuilder.DropColumn(
                name: "IdHoaDon",
                table: "ChiTietHoaDon");

            migrationBuilder.DropColumn(
                name: "IdThuCung",
                table: "ChiTietHoaDon");

            migrationBuilder.DropColumn(
                name: "SoLuong",
                table: "ChiTietHoaDon");

            migrationBuilder.DropColumn(
                name: "ThanhTien",
                table: "ChiTietHoaDon");

            migrationBuilder.RenameTable(
                name: "ChiTietHoaDon",
                newName: "ChiTietHoaDons");

            migrationBuilder.AddColumn<int>(
                name: "TinhTrang",
                table: "Carts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdHoaDon1",
                table: "ChiTietHoaDons",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdThuCung1",
                table: "ChiTietHoaDons",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ChiTietHoaDons",
                table: "ChiTietHoaDons",
                column: "IdChiTietHD");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietHoaDons_IdHoaDon1",
                table: "ChiTietHoaDons",
                column: "IdHoaDon1");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietHoaDons_IdThuCung1",
                table: "ChiTietHoaDons",
                column: "IdThuCung1");

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietHoaDons_HoaDons_IdHoaDon1",
                table: "ChiTietHoaDons",
                column: "IdHoaDon1",
                principalTable: "HoaDons",
                principalColumn: "IdHoaDon",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietHoaDons_thuCungs_IdThuCung1",
                table: "ChiTietHoaDons",
                column: "IdThuCung1",
                principalTable: "thuCungs",
                principalColumn: "IdThuCung",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
