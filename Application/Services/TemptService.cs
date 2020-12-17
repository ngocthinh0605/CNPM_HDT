using System.Collections.Generic;
using Application.DTOs;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using Domain.Repository;

namespace Application.Services
{
    public class TemptService : ITempService
    {
        private readonly ITemprepository tempRepository;
        private readonly IMapper iMapper;
        public TemptService(ITemprepository tempRepository,IMapper iMapper)
        {
            this.tempRepository=tempRepository;
            this.iMapper= iMapper;
        }

        public void Add(TemptDTO tempt)
        {
             var tam = iMapper.Map<TemptDTO, Tempt>(tempt);
                    tempRepository.Add(tam);
        }
        public IEnumerable<ThuCungDTO> GetThuCungs()
        {
            return iMapper.Map<IEnumerable<ThuCung>,IEnumerable<ThuCungDTO>>(tempRepository.GetThuCungs());
        }

        public IEnumerable<TemptDTO> GetChiTietHoaDons(int idhoadon)
        {
            return iMapper.Map<IEnumerable<Tempt>,IEnumerable<TemptDTO>>(tempRepository.GetChiTietHoaDons(idhoadon));
        }
    }
}