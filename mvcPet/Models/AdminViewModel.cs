using System.Collections.Generic;
using Application.DTOs;

namespace mvcPet.Models
{
    public class AdminViewModel
    {
        public int TotalLoai {get; set;}
        public int Totalsp {get; set;}
        public int TotalKH {get; set;}
        public int HDdanggiao {get; set;}
        public int HDdagiao {get; set;}
        public int HDdahuy{get; set;} 
        public float TotalDT{get; set;}
        public decimal TotalChi{get; set;}
        public decimal Total{get; set;}


        public IEnumerable<LoaiThuCungDTO> GetLoai {get; set;}
        public IEnumerable<ThuCungDTO> GetThuCung {get; set;}
        public IEnumerable<HoaDonDTO> GetHoaDonDangGiao {get; set;}
        public IEnumerable<HoaDonDTO> GetHoaDonDaGiao {get; set;}
        public IEnumerable<HoaDonDTO> GetHoaDonHuy {get; set;}
        public IEnumerable<TemptDTO> GetChiTietHoaDonDTO {get; set;}
        public IEnumerable<KhachHangDTO> GetKhachHangDTO {get; set;}
        public IEnumerable<NhanVienDTO> GetNhanVienDTO {get; set;}



    }
}