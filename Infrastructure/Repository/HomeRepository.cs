using System.Collections.Generic;
using System.Linq;
using Domain.Entities;
using Domain.Repository;
using Infrastructure.Persistence;

namespace Infrastructure.Repository
{
    public class HomeRepository : IHomeRepository
    {
        private readonly PetContext petContext;
        public HomeRepository(PetContext petContext)
        {
            this.petContext=petContext;
        }

        //Lấy danh sách Banner là SlideShow
        public IEnumerable<Banner> GetAll()
        {
           return petContext.banners.ToList();
        }

        public IEnumerable<LoaiThuCung> GetBest()
        {
            return petContext.loaiThuCungs.Where(m => m.ParentId== 1).ToList();
        }

         public IEnumerable<LoaiThuCung> GetFeatured()
        {
            return petContext.loaiThuCungs.Where(m => m.ParentId== 2).ToList();
        }
         public IEnumerable<LoaiThuCung> GetSale()
        {
            return petContext.loaiThuCungs.Where(m => m.ParentId== 3).ToList();
        }

        //lấy 4 con lên trang index
        public IEnumerable<LoaiThuCung> LoaiThuCung()
        {
            return petContext.loaiThuCungs.ToList();
        }
        public IEnumerable<ThuCung> GetThuCungIndex()
        {
            return petContext.thuCungs.Where(m => m.parentID==1 && m.IsFeatured==true).ToList();
        }
    }
}