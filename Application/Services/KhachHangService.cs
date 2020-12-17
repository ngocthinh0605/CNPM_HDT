using System.Collections.Generic;
using Application.DTOs;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using Domain.Repository;

namespace Application.Services
{
    public class KhachHangService : IKhachHangService
    {
        private readonly IKhachHangRepository nguoidungRepository;
        private readonly IMapper iMapper;
        public KhachHangService(IKhachHangRepository nguoidungRepository, IMapper iMapper  )
        {
            this.nguoidungRepository= nguoidungRepository;
            this.iMapper= iMapper;
        }

        public bool CheckTaiKhoan(string taiKhoan)
        {
            return nguoidungRepository.CheckTaiKhoan(taiKhoan);
        }

        public bool CheckTrangThai()
        {
            return nguoidungRepository.CheckTrangThai();
        }

        public void Create(KhachHangDTO khachHang)
        {
            var nguoiDung = iMapper.Map<KhachHangDTO, KhachHang>(khachHang);
            nguoidungRepository.Add(nguoiDung);
        }

        public  KhachHangDTO getKhachHang(string UserName,string MatKhau)
        {
             return iMapper.Map<KhachHang,KhachHangDTO>(nguoidungRepository.getKhachHang(UserName,MatKhau));
        }
    }
}