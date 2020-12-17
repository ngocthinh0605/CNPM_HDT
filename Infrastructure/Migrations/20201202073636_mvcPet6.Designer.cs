﻿// <auto-generated />
using System;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infrastructure.Migrations
{
    [DbContext(typeof(PetContext))]
    [Migration("20201202073636_mvcPet6")]
    partial class mvcPet6
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Domain.Entities.Banner", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenLoai")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("id");

                    b.ToTable("banners");
                });

            modelBuilder.Entity("Domain.Entities.ChiTietHoaDon", b =>
                {
                    b.Property<int>("IdChiTietHD")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("IdHoaDon1")
                        .HasColumnType("int");

                    b.Property<int?>("IdThuCung1")
                        .HasColumnType("int");

                    b.HasKey("IdChiTietHD");

                    b.HasIndex("IdHoaDon1");

                    b.HasIndex("IdThuCung1");

                    b.ToTable("ChiTietHoaDons");
                });

            modelBuilder.Entity("Domain.Entities.HoaDon", b =>
                {
                    b.Property<int>("IdHoaDon")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("IdKhachHangUserName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("IdNhanVienUserName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("NgayLap")
                        .HasColumnType("datetime2");

                    b.Property<int>("SoLuongMua")
                        .HasColumnType("int");

                    b.Property<float>("TongTien")
                        .HasColumnType("real");

                    b.HasKey("IdHoaDon");

                    b.HasIndex("IdKhachHangUserName");

                    b.HasIndex("IdNhanVienUserName");

                    b.ToTable("HoaDons");
                });

            modelBuilder.Entity("Domain.Entities.KhachHang", b =>
                {
                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("GioiTinh")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<string>("MatKhau")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SoDienThoai")
                        .HasColumnType("int");

                    b.Property<string>("TenUser")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("UserName");

                    b.ToTable("KhachHangs");
                });

            modelBuilder.Entity("Domain.Entities.LoaiThuCung", b =>
                {
                    b.Property<int>("IdLoaiThuCung")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CachNuoi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NgoaiHinh")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ParentId")
                        .HasColumnType("int");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.Property<string>("TapTinh")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenLoai")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("TuoiTho")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdLoaiThuCung");

                    b.ToTable("loaiThuCungs");
                });

            modelBuilder.Entity("Domain.Entities.NhanVien", b =>
                {
                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("GioiTinh")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<int?>("IdRole1")
                        .HasColumnType("int");

                    b.Property<string>("MatKhau")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SoDienThoai")
                        .HasColumnType("int");

                    b.Property<string>("TenUser")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("UserName");

                    b.HasIndex("IdRole1");

                    b.ToTable("NhanViens");
                });

            modelBuilder.Entity("Domain.Entities.OnSale", b =>
                {
                    b.Property<int>("IdOnSale")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<float>("GiaGiam")
                        .HasColumnType("real");

                    b.Property<DateTime>("NgayBD")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgayKT")
                        .HasColumnType("datetime2");

                    b.HasKey("IdOnSale");

                    b.ToTable("OnSales");
                });

            modelBuilder.Entity("Domain.Entities.OnSaleDetail", b =>
                {
                    b.Property<int>("IdOnSaleDetail")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("OnSaleIdOnSale")
                        .HasColumnType("int");

                    b.Property<int?>("ThuCungIdThuCung")
                        .HasColumnType("int");

                    b.HasKey("IdOnSaleDetail");

                    b.HasIndex("OnSaleIdOnSale");

                    b.HasIndex("ThuCungIdThuCung");

                    b.ToTable("OnSaleDetails");
                });

            modelBuilder.Entity("Domain.Entities.Role", b =>
                {
                    b.Property<int>("IdRole")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("TenRole")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("IdRole");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("Domain.Entities.ThuCung", b =>
                {
                    b.Property<int>("IdThuCung")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<float>("CanNang")
                        .HasColumnType("real");

                    b.Property<float>("GiaBan")
                        .HasColumnType("real");

                    b.Property<float>("GiaNhap")
                        .HasColumnType("real");

                    b.Property<int>("IdLoaiThuCung")
                        .HasColumnType("int");

                    b.Property<int?>("IdTrangThai1")
                        .HasColumnType("int");

                    b.Property<int?>("IdXuatXu1")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsFeatured")
                        .HasColumnType("bit");

                    b.Property<string>("MauLong")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.Property<DateTime>("NgaySinh")
                        .HasColumnType("datetime2");

                    b.Property<string>("TenThuCung")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.Property<int>("parentID")
                        .HasColumnType("int");

                    b.HasKey("IdThuCung");

                    b.HasIndex("IdTrangThai1");

                    b.HasIndex("IdXuatXu1");

                    b.ToTable("thuCungs");
                });

            modelBuilder.Entity("Domain.Entities.TrangThai", b =>
                {
                    b.Property<int>("IdTrangThai")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("TenTrangThai")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.HasKey("IdTrangThai");

                    b.ToTable("TrangThai");
                });

            modelBuilder.Entity("Domain.Entities.XuatXu", b =>
                {
                    b.Property<int>("IdXuatXu")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("TenXuatXu")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.HasKey("IdXuatXu");

                    b.ToTable("XuatXu");
                });

            modelBuilder.Entity("Domain.Entities.ChiTietHoaDon", b =>
                {
                    b.HasOne("Domain.Entities.HoaDon", "IdHoaDon")
                        .WithMany()
                        .HasForeignKey("IdHoaDon1");

                    b.HasOne("Domain.Entities.ThuCung", "IdThuCung")
                        .WithMany()
                        .HasForeignKey("IdThuCung1");

                    b.Navigation("IdHoaDon");

                    b.Navigation("IdThuCung");
                });

            modelBuilder.Entity("Domain.Entities.HoaDon", b =>
                {
                    b.HasOne("Domain.Entities.KhachHang", "IdKhachHang")
                        .WithMany()
                        .HasForeignKey("IdKhachHangUserName");

                    b.HasOne("Domain.Entities.NhanVien", "IdNhanVien")
                        .WithMany()
                        .HasForeignKey("IdNhanVienUserName");

                    b.Navigation("IdKhachHang");

                    b.Navigation("IdNhanVien");
                });

            modelBuilder.Entity("Domain.Entities.NhanVien", b =>
                {
                    b.HasOne("Domain.Entities.Role", "IdRole")
                        .WithMany()
                        .HasForeignKey("IdRole1");

                    b.Navigation("IdRole");
                });

            modelBuilder.Entity("Domain.Entities.OnSaleDetail", b =>
                {
                    b.HasOne("Domain.Entities.OnSale", "OnSale")
                        .WithMany()
                        .HasForeignKey("OnSaleIdOnSale");

                    b.HasOne("Domain.Entities.ThuCung", "ThuCung")
                        .WithMany()
                        .HasForeignKey("ThuCungIdThuCung");

                    b.Navigation("OnSale");

                    b.Navigation("ThuCung");
                });

            modelBuilder.Entity("Domain.Entities.ThuCung", b =>
                {
                    b.HasOne("Domain.Entities.TrangThai", "IdTrangThai")
                        .WithMany()
                        .HasForeignKey("IdTrangThai1");

                    b.HasOne("Domain.Entities.XuatXu", "IdXuatXu")
                        .WithMany()
                        .HasForeignKey("IdXuatXu1");

                    b.Navigation("IdTrangThai");

                    b.Navigation("IdXuatXu");
                });
#pragma warning restore 612, 618
        }
    }
}
