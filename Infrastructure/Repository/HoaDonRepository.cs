using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Entities;
using Domain.Repository;
using Infrastructure.Persistence;

namespace Infrastructure.Repository
{
    public class HoaDonRepository : IHoaDonRepository
    {
        private readonly PetContext petContext;
        public HoaDonRepository(PetContext petContext)
        {
            this.petContext=petContext;
        }
        
        public void Add(HoaDon hoaDon)
        {
            petContext.HoaDons.Add(hoaDon);
            petContext.SaveChanges();
        }

        public IEnumerable<HoaDon> GetHoaDon(string user)
        {
           return petContext.HoaDons.Where(m => m.IdKhachHangUserName==user).ToList();
        }

        public int GetIdHoaDOn()
        {
            var data = petContext.HoaDons.ToList();
            var dataa = data.OrderByDescending(m => m.IdHoaDon).First();
            return dataa.IdHoaDon;
        }

        

        public IEnumerable<TrangThai> GetTrangThai()
        {
           return petContext.TrangThai.ToList();
        }

        public void UpdateCancel(int IdHoaDon)
        {
            HoaDon hoadon = petContext.HoaDons.Single(p => p.IdHoaDon==IdHoaDon);
            hoadon.IdTrangThai=4;
            petContext.SaveChanges();
        }

        public void UpdateHoaDon(int IdHoaDon,int SL,float TT)
        {
             HoaDon hoadon = petContext.HoaDons.Single(p => p.IdHoaDon==IdHoaDon);
               hoadon.SoLuongMua=SL;
               hoadon.TongTien=TT;
                petContext.SaveChanges();
           
            
        }
    }
}