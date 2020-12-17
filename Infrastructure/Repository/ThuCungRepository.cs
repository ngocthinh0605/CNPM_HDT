using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Entities;
using Domain.Repository;
using Infrastructure.Persistence;
namespace Infrastructure.Repository
{
    public class ThuCungRepository : IThuCungRepository
    {
        private readonly PetContext petContext;
        public ThuCungRepository(PetContext petContext)
        {
            this.petContext=petContext;
        }
        public IEnumerable<LoaiThuCung> GetAll()
        {
            return petContext.loaiThuCungs.ToList();
        }

        public IEnumerable<Banner> GetBanners()
        {
            return petContext.banners.ToList();
        }

        public ThuCung GetBy(int id)
        {
            return petContext.thuCungs.Find(id);
        }

        public ThuCung GetSingerThuCung(int id)
        {
            return petContext.thuCungs.Single(m => m.IdThuCung==id);
        }

        public IEnumerable<ThuCung> GetThuCungs()
        {
           return petContext.thuCungs.Where(s => s.IsFeatured==true).ToList();
        }

       

        public int numberPage(int totalProduct, int limit)
        {
            float numberpage = totalProduct / limit;
            return (int)Math.Ceiling(numberpage);

        }

        // public IEnumerable<ThuCung> paginationPetProduct(int id,int start, int limit,string sortOrder)
        // {
        //     var data = (from s in petContext.thuCungs where s.IdLoaiThuCung==id select s);
        //     var dataProduct = data.OrderByDescending(m => m.TenThuCung)
        //     .Skip(start).Take(limit);
        //      switch (sortOrder)
        //     {
        //         case "TenLoai_desc":
        //             dataProduct = dataProduct.OrderByDescending(m => m.TenThuCung );
        //             break;
        //         case "TenLoai":
        //             dataProduct = dataProduct.OrderBy(m => m.TenThuCung);
        //             break; 
        //         case "GiaBan_desc":
        //             dataProduct = dataProduct.OrderByDescending(m => m.GiaBan);
        //             break;
        //         case "GiaBan":
        //             dataProduct = dataProduct.Where(m => m.IdLoaiThuCung == id).OrderBy(m => m.GiaBan);
        //             break;                      
        //     }
        //     return dataProduct.ToList();

        // }

        public IEnumerable<LoaiThuCung> paginationProduct(int start, int limit,string sortOrder, string searchString)
        {
             var data = (from s in petContext.loaiThuCungs 
                        select s)
                        .Skip(start).Take(limit);
            if(!string.IsNullOrEmpty(searchString))
            {
                data = data.Where(m => m.TenLoai.Contains(searchString));
            }
    
             switch (sortOrder)
            {
                case "TenLoai_desc":
                    data = data.OrderByDescending(m => m.TenLoai);
                    break;
                case "TenLoai":
                    data = data.OrderBy(m => m.TenLoai);
                    break;                       
            }
            return data.ToList();

        }

        public int PetnumberPage(int totalProduct, int limit)
        {
            float numberpage = totalProduct / limit;
            return (int)Math.Ceiling(numberpage);
        }

        public IEnumerable<ThuCung> Test(int id,int start, int limit,string sortOrder, string searchString,float GiaBan)
        {
            var data = (from s in petContext.thuCungs where s.IdLoaiThuCung==id && s.IsFeatured==true select s);
             var dataa = data.OrderBy(m => m.TenThuCung).Skip(start).Take(limit);
             
             if(!string.IsNullOrEmpty(searchString))
            {
                dataa = dataa.Where(m => m.TenThuCung.Contains(searchString));
            }
            
             if( GiaBan != 0)
            {
                dataa = dataa.Where(m => m.GiaBan.CompareTo(GiaBan)==-1 );
            }

              switch (sortOrder)
            {
                case "GiaBan_desc":
                    dataa = dataa.OrderByDescending(m => m.GiaBan);
                    break;
                case "GiaBan":
                    dataa = dataa.OrderBy(m => m.GiaBan);
                    break; 
                case "TenThuCung_desc":
                    dataa = dataa.OrderByDescending(m => m.TenThuCung);
                    break;
                case "TenThuCung":
                    dataa = dataa.OrderBy(m => m.TenThuCung);
                    break;                       
            }
           return dataa.ToList();
        }

        public int totalPetProduct()
        {
            return petContext.thuCungs.Count();
        }

        public int totalProduct()
        {
            return petContext.loaiThuCungs.Count();

        }

        public void UpDateFeatured(int IdThuCung)
        {
           ThuCung thuCung= petContext.thuCungs.Single(p => p.IdThuCung==IdThuCung);
            thuCung.IsFeatured=true;
            petContext.SaveChanges();
        }
    }
}