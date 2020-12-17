using System.Collections.Generic;
using Domain.Entities;

namespace Domain.Repository
{
    public interface IAdminRepository
    {
        int TotalLoai();
        int Totalsp();
        int TotalKH();
        int HDdanggiao();
        int HDdagiao();
        int HDdahuy();
        float TotalDT();
        float TotalChi();

        IEnumerable<LoaiThuCung> GetLoai();
        IEnumerable<KhachHang> GetNhanVien();


        IEnumerable<ThuCung> GetThuCung();
        IEnumerable<HoaDon> GetHoaDonDangGiao();
        IEnumerable<HoaDon> GetHoaDonDaGiao();
        IEnumerable<HoaDon> GetHoaDonHuy();
        IEnumerable<Tempt> GetChiTietHoaDon(int idhoadon);


        LoaiThuCung GetBy(int id);
        ThuCung GetByTC(int id);
        KhachHang GetByKH(string id);
        




        void Add(LoaiThuCung loai);

        void AddKH(KhachHang loai);
        void AddNV(NhanVien loai);




        
        void Delete(int id);
        void Edit(LoaiThuCung loai);
        void EditTC(ThuCung loai);

        
        void HideSP(int id);
        void ShowSP(int id);
        void HideKH(string user);
        void ShowKH(string user);
         void HideNV(string user);
        void ShowNV(string user);
        NhanVien GetByNV(string id);
        IEnumerable<NhanVien> GetNhanVienn();
         IEnumerable<HoaDon> Filter();
    }
}