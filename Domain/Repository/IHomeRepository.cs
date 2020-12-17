using System.Collections.Generic;
using Domain.Entities;

namespace Domain.Repository
{
    public interface IHomeRepository: IRepository<Banner>
    {
        IEnumerable<LoaiThuCung> LoaiThuCung();
        IEnumerable<LoaiThuCung> GetBest();
        IEnumerable<LoaiThuCung> GetFeatured();
        IEnumerable<LoaiThuCung> GetSale();
        IEnumerable<ThuCung> GetThuCungIndex();
        
    }
}