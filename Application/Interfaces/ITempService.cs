using System.Collections.Generic;
using Application.DTOs;

namespace Application.Interfaces
{
    public interface ITempService
    {
        IEnumerable<TemptDTO> GetChiTietHoaDons(int idhoadon);
        void Add(TemptDTO tempt);
        IEnumerable<ThuCungDTO> GetThuCungs();
        
    }
}