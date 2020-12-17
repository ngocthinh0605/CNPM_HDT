using System.Collections.Generic;
using Application.DTOs;

namespace Application.Interfaces
{
    public interface IChiTietHoaDonService
    {
        void Create(ChiTietHoaDonDTO hoaDon)  ;
        void Remove(int idhoadon);

        // IEnumerable<ThuCungDTO> GetThuCungs();

        int SumSoLuong(int idhoadon);
        float SumTongTien(int idhoadon);
    }
}