using System.Collections.Generic;
using Application.DTOs;

namespace Application.Interfaces
{
    public interface IHomeService
    {
         IEnumerable<BannerDTO> GetAll();
         //lấy 4 con trên trang index
         IEnumerable<LoaiThuCungDTO> Get4forIndex();
         IEnumerable<LoaiThuCungDTO> LoaiThuCung();

         //lấy best
         IEnumerable<LoaiThuCungDTO> GetBest();
         IEnumerable<LoaiThuCungDTO> GetFeatured();
         IEnumerable<LoaiThuCungDTO> GetSale();
         IEnumerable<ThuCungDTO> GetThuCungIndex();

    }
}