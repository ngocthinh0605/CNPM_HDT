using Application.DTOs;
using AutoMapper;
using Domain.Entities;

namespace Application.Mapping
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<ThuCung, ThuCungDTO>();
            CreateMap<ThuCungDTO, ThuCung>();
            
            CreateMap<KhachHang, KhachHangDTO>();
            CreateMap<KhachHangDTO, KhachHang>();
            
            CreateMap<NhanVien, NhanVienDTO>();
            CreateMap<NhanVienDTO, NhanVien>();

            CreateMap<HoaDon, HoaDonDTO>();
            CreateMap<HoaDonDTO, HoaDon>();

             CreateMap<TrangThai, TrangThaiDTO>();
            CreateMap<TrangThaiDTO, TrangThai>();

            CreateMap<LoaiThuCung, LoaiThuCungDTO>();
            CreateMap<LoaiThuCungDTO,LoaiThuCung>();
            
            CreateMap<Banner, BannerDTO>();
            CreateMap<BannerDTO,Banner>();
            
            CreateMap<CartDB, CartDBDTO>();
            CreateMap<CartDBDTO,CartDB>();
            
            CreateMap<ChiTietHoaDon, ChiTietHoaDonDTO>();
            CreateMap<ChiTietHoaDonDTO,ChiTietHoaDon>();

            CreateMap<Tempt, TemptDTO>();
            CreateMap<TemptDTO,TemptDTO>();
           
            
           
        }
    }
}