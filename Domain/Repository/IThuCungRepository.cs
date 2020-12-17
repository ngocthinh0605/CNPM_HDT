using System.Collections.Generic;
using Domain.Entities;


namespace Domain.Repository
{
    public interface IThuCungRepository:IRepository<LoaiThuCung>
    {
        IEnumerable<Banner> GetBanners();
        //phân trang loại
        int totalProduct();
        int numberPage(int totalProduct, int limit);
        IEnumerable<LoaiThuCung> paginationProduct(int start, int limit,string sortOrder, string searchString);
        //phân trang thú cưng
        int totalPetProduct();
        int PetnumberPage(int totalProduct, int limit);
        // IEnumerable<ThuCung> paginationPetProduct(int id,int start, int limit,string sortOrder);
        IEnumerable<ThuCung> GetThuCungs();
        
        IEnumerable<ThuCung> Test(int id,int start, int limit,string sortOrder,string searchString,float GiaBan);
        ThuCung GetBy(int id);
        void UpDateFeatured(int IdThuCung);
        ThuCung GetSingerThuCung(int id);
       
    }
}