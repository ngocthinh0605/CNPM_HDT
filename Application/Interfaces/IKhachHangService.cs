using System.Collections.Generic;
using Application.DTOs;

namespace Application.Interfaces
{
    public interface IKhachHangService
    {
         KhachHangDTO getKhachHang(string UserName,string MatKhau);
        //  bool CheckTaiKhoan(string username);
         void Create(KhachHangDTO khachHang);
        bool CheckTaiKhoan(string taiKhoan);
        bool CheckTrangThai();
    }
}