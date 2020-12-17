using System.Collections.Generic;
using Application.DTOs;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using Domain.Repository;

namespace Application.Services
{
    public class AdminService : IAdminService
    {
        private readonly IAdminRepository adRepository;
        private readonly IMapper iMapper;
        public AdminService(IAdminRepository adRepository, IMapper iMapper  )
        {
            this.adRepository= adRepository;
            this.iMapper= iMapper;
        }

        public void Add(LoaiThuCungDTO loai)
        {
            var Loai = iMapper.Map<LoaiThuCungDTO, LoaiThuCung>(loai);
            adRepository.Add(Loai);
        }

        public void AddKH(KhachHangDTO loai)
        {
           var Loai = iMapper.Map<KhachHangDTO, KhachHang>(loai);
            adRepository.AddKH(Loai);
        }

        public void AddNV(NhanVienDTO loai)
        {
            var Loai = iMapper.Map<NhanVienDTO,NhanVien>(loai);
            adRepository.AddNV(Loai);
        }

        public void Delete(int id)
        {
           
            adRepository.Delete(id);
        }

        public void Edit(LoaiThuCungDTO loai)
        {
            var Loai = iMapper.Map<LoaiThuCungDTO, LoaiThuCung>(loai);
            adRepository.Edit(Loai);
        }

        public void EditTC(ThuCungDTO thuCung)
        {
           var thuCung1= iMapper.Map<ThuCungDTO, ThuCung>(thuCung);
            adRepository.EditTC(thuCung1);
        }

        public IEnumerable<HoaDonDTO> Filter()
        {
            return iMapper.Map<IEnumerable<HoaDon>,IEnumerable<HoaDonDTO>>(adRepository.Filter());;
        }

        public LoaiThuCungDTO GetBy(int id)
        {
             return iMapper.Map<LoaiThuCung,LoaiThuCungDTO>(adRepository.GetBy(id));
        }

        public KhachHangDTO GetByKH(string id)
        {
            return iMapper.Map<KhachHang,KhachHangDTO>(adRepository.GetByKH(id));
        }

        public NhanVienDTO GetByNV(string id)
        {
            return iMapper.Map<NhanVien,NhanVienDTO>(adRepository.GetByNV(id));
        }

        public ThuCungDTO GetByTC(int id)
        {
             return iMapper.Map<ThuCung,ThuCungDTO>(adRepository.GetByTC(id));
        }

        public IEnumerable<TemptDTO> GetChiTietHoaDon(int idhoadon)
        {
            return iMapper.Map<IEnumerable<Tempt>,IEnumerable<TemptDTO>>(adRepository.GetChiTietHoaDon(idhoadon));;
        }

        public IEnumerable<HoaDonDTO> GetHoaDonDaGiao()
        {
           return iMapper.Map<IEnumerable<HoaDon>,IEnumerable<HoaDonDTO>>(adRepository.GetHoaDonDaGiao());
        }

        public IEnumerable<HoaDonDTO> GetHoaDonDangGiao()
        {
            return iMapper.Map<IEnumerable<HoaDon>,IEnumerable<HoaDonDTO>>(adRepository.GetHoaDonDangGiao());
        }

        public IEnumerable<HoaDonDTO> GetHoaDonHuy()
        {
            return iMapper.Map<IEnumerable<HoaDon>,IEnumerable<HoaDonDTO>>(adRepository.GetHoaDonHuy());
        }

        public IEnumerable<LoaiThuCungDTO> GetLoai()
        {
            return iMapper.Map<IEnumerable<LoaiThuCung>,IEnumerable<LoaiThuCungDTO>>(adRepository.GetLoai());
        }

        public IEnumerable<KhachHangDTO> GetNhanVien()
        {
            return iMapper.Map<IEnumerable<KhachHang>,IEnumerable<KhachHangDTO>>(adRepository.GetNhanVien());
        }

        public IEnumerable<NhanVienDTO> GetNhanVienn()
        {
           return iMapper.Map<IEnumerable<NhanVien>,IEnumerable<NhanVienDTO>>(adRepository.GetNhanVienn());
        }

        public IEnumerable<ThuCungDTO> GetThuCung()
        {
            return iMapper.Map<IEnumerable<ThuCung>,IEnumerable<ThuCungDTO>>(adRepository.GetThuCung());
        }

        public int HDdagiao()
        {
            return adRepository.HDdagiao();
        }

        public int HDdahuy()
        {
            return adRepository.HDdahuy();
        }

        public int HDdanggiao()
        {
            return adRepository.HDdanggiao();
        }

        public void HideKH(string user)
        {
           adRepository.HideKH(user);
        }

        public void HideNV(string user)
        {
            adRepository.HideNV(user);
        }

        public void HideSP(int id)
        {
            adRepository.HideSP(id);
        }

        public void ShowKH(string user)
        {
            adRepository.ShowKH(user);
        }

        public void ShowNV(string user)
        {
            adRepository.ShowNV(user);
        }

        public void ShowSP(int id)
        {
            adRepository.ShowSP(id);
        }

        public float TotalChi()
        {
            return adRepository.TotalChi();
        }

        public float TotalDT()
        {
            return adRepository.TotalDT();
        }

        public int TotalKH()
        {
            return adRepository.TotalKH();
        }

        public int TotalLoai()
        {
            return adRepository.TotalLoai();
        }

        public int Totalsp()
        {
            return adRepository.Totalsp();
        }

    
    }
}