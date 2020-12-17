using System;
using System.Collections.Generic;
using Application.DTOs;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using Domain.Repository;

namespace Application.Services
{
    public class HoaDonService : IHoaDonService
    {
        private readonly IHoaDonRepository hoaDonRepository;
        private readonly IMapper iMapper;
        public HoaDonService(IHoaDonRepository hoaDonRepository,IMapper iMapper)
        {
            this.hoaDonRepository= hoaDonRepository;
            this.iMapper= iMapper;
        }
        public void Create(HoaDonDTO hoaDon)
        {
            var hoadon = iMapper.Map<HoaDonDTO, HoaDon>(hoaDon);
            hoaDonRepository.Add(hoadon);
        }

        public IEnumerable<HoaDonDTO> GetHoaDon(string user)
        {
            return iMapper.Map<IEnumerable<HoaDon>,IEnumerable<HoaDonDTO>>(hoaDonRepository.GetHoaDon(user));
        }

        public int GetIdHoaDOn()
        {
           return hoaDonRepository.GetIdHoaDOn();
        }
        

        public IEnumerable<TrangThaiDTO> GetTrangThai()
        {
            return iMapper.Map<IEnumerable<TrangThai>,IEnumerable<TrangThaiDTO>>(hoaDonRepository.GetTrangThai());
        }

        public void UpdateCancel(int IdHoaDon)
        {
           hoaDonRepository.UpdateCancel(IdHoaDon);
        }

        public void UpdateHoaDon(int IdHoaDon,int SL,float TT)
        {
           
            hoaDonRepository.UpdateHoaDon(IdHoaDon,SL,TT);
        }

        
    }
}