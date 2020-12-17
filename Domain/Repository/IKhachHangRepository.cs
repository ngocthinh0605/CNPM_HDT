using System.Collections.Generic;
using Domain.Entities;

namespace Domain.Repository
{
    public interface IKhachHangRepository
    {
        KhachHang getKhachHang(string UserName,string MatKhau);
        // bool CheckTaiKhoan(string taiKhoan);
        void Add(KhachHang khachHang);
         bool CheckTaiKhoan(string taiKhoan);
         bool CheckTrangThai();

    }
}