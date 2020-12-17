using System.Collections.Generic;
using Application.DTOs;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using Domain.Repository;

namespace Application.Services
{
    public class ThuCungService: IThuCungService
    {
        private readonly IThuCungRepository thucungRepository;
        private readonly IMapper iMapper;
        public ThuCungService(IThuCungRepository thucungRepository, IMapper iMapper  )
        {
            this.thucungRepository= thucungRepository;
            this.iMapper= iMapper;
        }

        public IEnumerable<LoaiThuCungDTO> GetAll()
        {
            return iMapper.Map<IEnumerable<LoaiThuCung>,IEnumerable<LoaiThuCungDTO>>(thucungRepository.GetAll());
        }

        public IEnumerable<BannerDTO> GetBanner()
        {
            return iMapper.Map<IEnumerable<Banner>,IEnumerable<BannerDTO>>(thucungRepository.GetBanners());
        }

        public ThuCungDTO GetBy(int id)
        {
            return iMapper.Map<ThuCung,ThuCungDTO>(thucungRepository.GetBy(id));
            
        }

        public ThuCungDTO GetSingerThuCung(int id)
        {
            return iMapper.Map<ThuCung,ThuCungDTO>(thucungRepository.GetSingerThuCung(id)
            );
        }

        public IEnumerable<ThuCungDTO> GetThuCungDTOs(int id,int start, int limit,string sortOrder,string searchString,float GiaBan)
        {
            return iMapper.Map<IEnumerable<ThuCung>,IEnumerable<ThuCungDTO>>(thucungRepository.Test(id,start,limit,sortOrder,searchString,GiaBan));
        }

        public IEnumerable<ThuCungDTO> GetThuCungs()
        {
            return iMapper.Map<IEnumerable<ThuCung>,IEnumerable<ThuCungDTO>>(thucungRepository.GetThuCungs());
        }


        public int numberPage(int totalProduct, int limit)
        {
             return thucungRepository.numberPage(totalProduct,limit);
        }

        // public IEnumerable<ThuCungDTO> paginationPetProduct(int id,int start, int limit,string sortOrder)
        // {
        //      return iMapper.Map<IEnumerable<ThuCung>,IEnumerable<ThuCungDTO>>(thucungRepository.paginationPetProduct(id,start,limit,sortOrder));
        // }

        public IEnumerable<LoaiThuCungDTO> paginationProduct(int start, int limit,string sortOrder, string searchString)
        {
            return iMapper.Map<IEnumerable<LoaiThuCung>,IEnumerable<LoaiThuCungDTO>>(thucungRepository.paginationProduct(start,limit,sortOrder,searchString));
        }

        public int PetnumberPage(int totalProduct, int limit)
        {
            return thucungRepository.PetnumberPage(totalProduct,limit);
        }

        public int totalPetProduct()
        {
             return thucungRepository.totalPetProduct();
        }

        public int totalProduct()
        {
           return thucungRepository.totalProduct();
        }

        public void UpDateFeatured(int IdThuCung)
        {
           thucungRepository.UpDateFeatured(IdThuCung);
        }
    }
}