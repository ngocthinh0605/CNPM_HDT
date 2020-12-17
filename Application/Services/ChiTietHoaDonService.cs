using System.Collections.Generic;
using Application.DTOs;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using Domain.Repository;

namespace Application.Services
{
    public class ChiTietHoaDonService: IChiTietHoaDonService
    {
        private readonly IChiTietHoaDonRepository chiTiethoaDonRepository;
        private readonly IMapper iMapper;
        public ChiTietHoaDonService(IChiTietHoaDonRepository chiTiethoaDonRepository,IMapper iMapper)
        {
            this.chiTiethoaDonRepository=chiTiethoaDonRepository;
            this.iMapper= iMapper;
        }

        public void Create(ChiTietHoaDonDTO hoaDon)
        {
            var hoadon = iMapper.Map<ChiTietHoaDonDTO, ChiTietHoaDon>(hoaDon);
            chiTiethoaDonRepository.Add(hoadon);
        }
        

       

        public void Remove(int idhoadon)
        {
            chiTiethoaDonRepository.Remove(idhoadon);
        }

        // public IEnumerable<ThuCungDTO> GetThuCungs()
        // {
        //     return iMapper.Map<IEnumerable<ThuCung>,IEnumerable<ThuCungDTO>>(chiTiethoaDonRepository.GetThuCungs());
        // }

        public int SumSoLuong(int idhoadon)
        {
            return chiTiethoaDonRepository.SumSoLuong(idhoadon);
        }

        public float SumTongTien(int idhoadon)
        {
            return chiTiethoaDonRepository.SumTongTien(idhoadon);
        }
    }
}