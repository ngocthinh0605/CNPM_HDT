using System.Collections.Generic;
using System.Linq;
using Domain.Entities;
using Domain.Repository;
using Infrastructure.Persistence;

namespace Infrastructure.Repository
{
    public class KhachHangRepository : IKhachHangRepository
    {
        private readonly PetContext petContext;
        public KhachHangRepository(PetContext petContext)
        {
            this.petContext=petContext;
        }

        public void Add(KhachHang khachHang)
        {
            petContext.KhachHangs.Add(khachHang);
            petContext.SaveChanges();
        }

        public bool CheckTaiKhoan(string taiKhoan)
        {
            return petContext.KhachHangs.Count(x => x.UserName == taiKhoan) > 0;
        }

        public bool CheckTrangThai()
        {
            return petContext.KhachHangs.Count(x => x.TrangThai==1) > 0;
        }

        public KhachHang getKhachHang(string UserName, string MatKhau)
        {
           var KhachHang= from m in petContext.KhachHangs
                             where m.UserName ==UserName
                             select m;
            if(KhachHang.Count() > 0)
            {
                if(KhachHang.First().MatKhau == MatKhau)
                {
                    return KhachHang.First();
                }
                return null;
            }  
            return null;               
        }
    }
}