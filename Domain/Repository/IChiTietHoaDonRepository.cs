using System.Collections.Generic;
using Domain.Entities;

namespace Domain.Repository
{
    public interface IChiTietHoaDonRepository
    {
        void Add(ChiTietHoaDon hoaDon);
        void Remove(int idhoadon);
        int SumSoLuong(int idhoadon);
        float SumTongTien(int idhoadon);
       
        IEnumerable<ThuCung> GetThuCungs();


    }
}