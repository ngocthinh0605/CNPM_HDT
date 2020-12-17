using System;
using System.Collections.Generic;
using Application.DTOs;

namespace Application.Interfaces
{
    public interface IHoaDonService
    {
      void Create(HoaDonDTO hoaDon)  ; 
      int GetIdHoaDOn();
      void UpdateHoaDon(int IdHoaDon,int SL,float TT);
      void UpdateCancel(int IdHoaDon);
        IEnumerable<HoaDonDTO> GetHoaDon(string user);
        IEnumerable<TrangThaiDTO> GetTrangThai();
        

    }
 
}