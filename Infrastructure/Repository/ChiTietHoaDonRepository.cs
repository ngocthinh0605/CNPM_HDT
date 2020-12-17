using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Entities;
using Domain.Repository;
using Infrastructure.Persistence;

namespace Infrastructure.Repository
{
    public class ChiTietHoaDonRepository : IChiTietHoaDonRepository
    {
        private readonly PetContext petContext;
        public ChiTietHoaDonRepository(PetContext petContext)
        {
            this.petContext=petContext;
        }
        public void Add(ChiTietHoaDon chiTietHoaDon)
        {
            petContext.ChiTietHoaDon.Add(chiTietHoaDon);
            petContext.SaveChanges();
        }
       
       

        public IEnumerable<ThuCung> GetThuCungs()
        {
             return petContext.thuCungs.Where(s =>  s.IsFeatured==true).ToList();
        }

        public int SumSoLuong(int idhoadon)
        {
            var data= petContext.ChiTietHoaDon.Where(m => m.IdHoaDon==idhoadon).ToList();
            return data.Sum(m => m.SoLuong);
        }

        public float SumTongTien(int idhoadon)
        {
            var data= petContext.ChiTietHoaDon.Where(m => m.IdHoaDon==idhoadon).ToList();
            return data.Sum(m => m.ThanhTien);
        }
       

        public void Remove(int idhoadon)
        {
            ChiTietHoaDon cthd =petContext.ChiTietHoaDon.Single(p => p.IdHoaDon==idhoadon);
            petContext.ChiTietHoaDon.Remove(cthd);
            petContext.SaveChanges();
        }
    }
}