using System.Collections.Generic;
using Application.DTOs;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using Domain.Repository;

namespace Application.Services
{
    public class HomeService : IHomeService
    {
        private readonly IHomeRepository homeRepository;
        private readonly IMapper iMapper;
        public HomeService(IHomeRepository homeRepository, IMapper iMapper  )
        {
            this.homeRepository= homeRepository;
            this.iMapper= iMapper;
        }

        public IEnumerable<LoaiThuCungDTO> GetBest()
        {
            return iMapper.Map<IEnumerable<LoaiThuCung>,IEnumerable<LoaiThuCungDTO>>(homeRepository.GetBest());
        }
        public IEnumerable<LoaiThuCungDTO> GetFeatured()
        {
            return iMapper.Map<IEnumerable<LoaiThuCung>,IEnumerable<LoaiThuCungDTO>>(homeRepository.GetFeatured());
        }
        public IEnumerable<LoaiThuCungDTO> GetSale()
        {
            return iMapper.Map<IEnumerable<LoaiThuCung>,IEnumerable<LoaiThuCungDTO>>(homeRepository.GetSale());
        }

        public IEnumerable<LoaiThuCungDTO> Get4forIndex()
        {
             return iMapper.Map<IEnumerable<LoaiThuCung>,IEnumerable<LoaiThuCungDTO>>(homeRepository.GetBest());
        }

         public IEnumerable<ThuCungDTO> GetThuCungIndex()
        {
             return iMapper.Map<IEnumerable<ThuCung>,IEnumerable<ThuCungDTO>>(homeRepository.GetThuCungIndex());
        }

        public IEnumerable<BannerDTO> GetAll()
        {
             return iMapper.Map<IEnumerable<Banner>,IEnumerable<BannerDTO>>(homeRepository.GetAll());
        }

        public IEnumerable<LoaiThuCungDTO> LoaiThuCung()
        {
            return iMapper.Map<IEnumerable<LoaiThuCung>,IEnumerable<LoaiThuCungDTO>>(homeRepository.LoaiThuCung());
        }
    }
}