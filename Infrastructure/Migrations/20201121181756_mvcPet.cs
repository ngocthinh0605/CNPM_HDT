using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class mvcPet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "banners",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenLoai = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_banners", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "KhachHangs",
                columns: table => new
                {
                    UserName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MatKhau = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TenUser = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    SoDienThoai = table.Column<int>(type: "int", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    GioiTinh = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHangs", x => x.UserName);
                });

            migrationBuilder.CreateTable(
                name: "loaiThuCungs",
                columns: table => new
                {
                    IdLoaiThuCung = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenLoai = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    TapTinh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgoaiHinh = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_loaiThuCungs", x => x.IdLoaiThuCung);
                });

            migrationBuilder.CreateTable(
                name: "OnSales",
                columns: table => new
                {
                    IdOnSale = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GiaGiam = table.Column<float>(type: "real", nullable: false),
                    NgayBD = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayKT = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OnSales", x => x.IdOnSale);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    IdRole = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenRole = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.IdRole);
                });

            migrationBuilder.CreateTable(
                name: "TrangThai",
                columns: table => new
                {
                    IdTrangThai = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenTrangThai = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrangThai", x => x.IdTrangThai);
                });

            migrationBuilder.CreateTable(
                name: "XuatXu",
                columns: table => new
                {
                    IdXuatXu = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenXuatXu = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_XuatXu", x => x.IdXuatXu);
                });

            migrationBuilder.CreateTable(
                name: "NhanViens",
                columns: table => new
                {
                    UserName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IdRole1 = table.Column<int>(type: "int", nullable: true),
                    MatKhau = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TenUser = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    SoDienThoai = table.Column<int>(type: "int", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    GioiTinh = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanViens", x => x.UserName);
                    table.ForeignKey(
                        name: "FK_NhanViens_Role_IdRole1",
                        column: x => x.IdRole1,
                        principalTable: "Role",
                        principalColumn: "IdRole",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "thuCungs",
                columns: table => new
                {
                    IdThuCung = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenThuCung = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CanNang = table.Column<float>(type: "real", nullable: false),
                    MauLong = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: false),
                    GiaNhap = table.Column<float>(type: "real", nullable: false),
                    GiaBan = table.Column<float>(type: "real", nullable: false),
                    IdTrangThai1 = table.Column<int>(type: "int", nullable: true),
                    IdXuatXu1 = table.Column<int>(type: "int", nullable: true),
                    IdLoaiThuCung = table.Column<int>(type: "int", nullable: false),
                    IsFeatured = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_thuCungs", x => x.IdThuCung);
                    table.ForeignKey(
                        name: "FK_thuCungs_TrangThai_IdTrangThai1",
                        column: x => x.IdTrangThai1,
                        principalTable: "TrangThai",
                        principalColumn: "IdTrangThai",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_thuCungs_XuatXu_IdXuatXu1",
                        column: x => x.IdXuatXu1,
                        principalTable: "XuatXu",
                        principalColumn: "IdXuatXu",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HoaDons",
                columns: table => new
                {
                    IdHoaDon = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NgayLap = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SoLuongMua = table.Column<int>(type: "int", nullable: false),
                    TongTien = table.Column<float>(type: "real", nullable: false),
                    IdKhachHangUserName = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    IdNhanVienUserName = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDons", x => x.IdHoaDon);
                    table.ForeignKey(
                        name: "FK_HoaDons_KhachHangs_IdKhachHangUserName",
                        column: x => x.IdKhachHangUserName,
                        principalTable: "KhachHangs",
                        principalColumn: "UserName",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HoaDons_NhanViens_IdNhanVienUserName",
                        column: x => x.IdNhanVienUserName,
                        principalTable: "NhanViens",
                        principalColumn: "UserName",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OnSaleDetails",
                columns: table => new
                {
                    IdOnSaleDetail = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ThuCungIdThuCung = table.Column<int>(type: "int", nullable: true),
                    OnSaleIdOnSale = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OnSaleDetails", x => x.IdOnSaleDetail);
                    table.ForeignKey(
                        name: "FK_OnSaleDetails_OnSales_OnSaleIdOnSale",
                        column: x => x.OnSaleIdOnSale,
                        principalTable: "OnSales",
                        principalColumn: "IdOnSale",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OnSaleDetails_thuCungs_ThuCungIdThuCung",
                        column: x => x.ThuCungIdThuCung,
                        principalTable: "thuCungs",
                        principalColumn: "IdThuCung",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietHoaDons",
                columns: table => new
                {
                    IdChiTietHD = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdThuCung1 = table.Column<int>(type: "int", nullable: true),
                    IdHoaDon1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietHoaDons", x => x.IdChiTietHD);
                    table.ForeignKey(
                        name: "FK_ChiTietHoaDons_HoaDons_IdHoaDon1",
                        column: x => x.IdHoaDon1,
                        principalTable: "HoaDons",
                        principalColumn: "IdHoaDon",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ChiTietHoaDons_thuCungs_IdThuCung1",
                        column: x => x.IdThuCung1,
                        principalTable: "thuCungs",
                        principalColumn: "IdThuCung",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietHoaDons_IdHoaDon1",
                table: "ChiTietHoaDons",
                column: "IdHoaDon1");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietHoaDons_IdThuCung1",
                table: "ChiTietHoaDons",
                column: "IdThuCung1");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDons_IdKhachHangUserName",
                table: "HoaDons",
                column: "IdKhachHangUserName");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDons_IdNhanVienUserName",
                table: "HoaDons",
                column: "IdNhanVienUserName");

            migrationBuilder.CreateIndex(
                name: "IX_NhanViens_IdRole1",
                table: "NhanViens",
                column: "IdRole1");

            migrationBuilder.CreateIndex(
                name: "IX_OnSaleDetails_OnSaleIdOnSale",
                table: "OnSaleDetails",
                column: "OnSaleIdOnSale");

            migrationBuilder.CreateIndex(
                name: "IX_OnSaleDetails_ThuCungIdThuCung",
                table: "OnSaleDetails",
                column: "ThuCungIdThuCung");

            migrationBuilder.CreateIndex(
                name: "IX_thuCungs_IdTrangThai1",
                table: "thuCungs",
                column: "IdTrangThai1");

            migrationBuilder.CreateIndex(
                name: "IX_thuCungs_IdXuatXu1",
                table: "thuCungs",
                column: "IdXuatXu1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "banners");

            migrationBuilder.DropTable(
                name: "ChiTietHoaDons");

            migrationBuilder.DropTable(
                name: "loaiThuCungs");

            migrationBuilder.DropTable(
                name: "OnSaleDetails");

            migrationBuilder.DropTable(
                name: "HoaDons");

            migrationBuilder.DropTable(
                name: "OnSales");

            migrationBuilder.DropTable(
                name: "thuCungs");

            migrationBuilder.DropTable(
                name: "KhachHangs");

            migrationBuilder.DropTable(
                name: "NhanViens");

            migrationBuilder.DropTable(
                name: "TrangThai");

            migrationBuilder.DropTable(
                name: "XuatXu");

            migrationBuilder.DropTable(
                name: "Role");
        }
    }
}
