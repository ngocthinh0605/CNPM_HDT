using System.Collections.Generic;
using Domain.Entities;

namespace Domain.Repository
{
    public interface ITemprepository
    {
        void Add(Tempt tempt);

        IEnumerable<Tempt> GetChiTietHoaDons(int idhoadon);
        IEnumerable<ThuCung> GetThuCungs();

        
    }
}