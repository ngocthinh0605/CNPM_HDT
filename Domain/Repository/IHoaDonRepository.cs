using System;
using System.Collections.Generic;
using Domain.Entities;

namespace Domain.Repository
{
    public interface IHoaDonRepository
    {
        void Add(HoaDon hoaDon);
        int GetIdHoaDOn();
        
        
        void UpdateHoaDon(int IdHoaDon,int SL,float TT);
        void UpdateCancel(int IdHoaDon);

        IEnumerable<HoaDon> GetHoaDon(string user);
        IEnumerable<TrangThai> GetTrangThai();
        

    }
}