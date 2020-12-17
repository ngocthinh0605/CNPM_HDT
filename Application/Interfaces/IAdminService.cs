using System.Collections.Generic;
using Application.DTOs;

namespace Application.Interfaces
{
    public interface IAdminService
    {
        int TotalLoai();
        int Totalsp();
        int TotalKH();
        int HDdanggiao();
        int HDdagiao();
        int HDdahuy();
        float TotalDT();
        float TotalChi();

        
        IEnumerable<LoaiThuCungDTO> GetLoai();
        IEnumerable<ThuCungDTO> GetThuCung();
        void Add(LoaiThuCungDTO loai);
        LoaiThuCungDTO GetBy(int id);
        ThuCungDTO GetByTC(int id);
        void Edit(LoaiThuCungDTO loai);
        void EditTC(ThuCungDTO thuCung);
        void Delete(int id);
        IEnumerable<HoaDonDTO> GetHoaDonDangGiao();
        IEnumerable<HoaDonDTO> GetHoaDonDaGiao();
        void HideNV(string user);
        void ShowNV(string user);
        NhanVienDTO GetByNV(string id);
        IEnumerable<NhanVienDTO> GetNhanVienn();
        IEnumerable<HoaDonDTO> GetHoaDonHuy();
        IEnumerable<KhachHangDTO> GetNhanVien();
        IEnumerable<TemptDTO> GetChiTietHoaDon(int idhoadon);
        void HideSP(int id);
        void AddNV(NhanVienDTO loai);
        void ShowSP(int id);
        void AddKH(KhachHangDTO loai);
        KhachHangDTO GetByKH(string id);
        void HideKH(string user);
        void ShowKH(string user);
        IEnumerable<HoaDonDTO> Filter();

    }
}