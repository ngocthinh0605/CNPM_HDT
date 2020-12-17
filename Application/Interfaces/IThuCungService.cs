using System.Collections.Generic;
using Application.DTOs;


namespace Application.Interfaces
{
    public interface IThuCungService
    {
         IEnumerable<LoaiThuCungDTO> GetAll();
         IEnumerable<BannerDTO> GetBanner();
         int totalProduct();
        int numberPage(int totalProduct, int limit);
        IEnumerable<LoaiThuCungDTO> paginationProduct(int start, int limit,string sortOrder, string searchString);
        IEnumerable<ThuCungDTO> GetThuCungs();
        IEnumerable<ThuCungDTO> GetThuCungDTOs(int id,int start, int limit,string sortOrder,string searchString,float GiaBan);

         int totalPetProduct();
        int PetnumberPage(int totalProduct, int limit);
        ThuCungDTO GetBy(int id);
        void UpDateFeatured(int IdThuCung);
        ThuCungDTO GetSingerThuCung(int id);
        // IEnumerable<ThuCungDTO> paginationPetProduct(int id,int start, int limit,string sortOrder);
    }
}