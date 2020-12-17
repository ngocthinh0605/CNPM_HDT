using System.Collections.Generic;
using System.Linq;
using Domain.Entities;
using Domain.Repository;
using Infrastructure.Persistence;

namespace Infrastructure.Repository
{
    public class AdminRepository : IAdminRepository
    {
        private readonly PetContext petContext;
       
        public AdminRepository(PetContext petContext)
        {
            this.petContext=petContext;
        }

        public void Add(LoaiThuCung loai)
        {
            
            petContext.loaiThuCungs.Add(loai);
            petContext.SaveChanges();
        }

        public void AddKH(KhachHang loai)
        {
            petContext.KhachHangs.Add(loai);
            petContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var loai =  petContext.loaiThuCungs.Find(id);
            petContext.loaiThuCungs.Remove(loai);
            petContext.SaveChanges();
        }

        public void Edit(LoaiThuCung loai)
        {
            petContext.loaiThuCungs.Update(loai);
            petContext.SaveChanges();
        }

        public void EditTC(ThuCung thuCung)
        {
             petContext.thuCungs.Update(thuCung);
            petContext.SaveChanges();;
        }

        public LoaiThuCung GetBy(int id)
        {
            return petContext.loaiThuCungs.Find(id);
        }

        public KhachHang GetByKH(string id)
        {
            return petContext.KhachHangs.Find(id);
        }

        public ThuCung GetByTC(int id)
        {
            return petContext.thuCungs.Find(id);
        }

        public IEnumerable<Tempt> GetChiTietHoaDon(int idhoadon)
        {
            return petContext.Temp.Where(m => m.IdHoaDon==idhoadon).ToList();
        }

        public IEnumerable<HoaDon> GetHoaDonDaGiao()
        {
            return petContext.HoaDons.Where(m => m.IdTrangThai==7).ToList();
        }

        public IEnumerable<HoaDon> GetHoaDonDangGiao()
        {
            return petContext.HoaDons.Where(m => m.IdTrangThai==3).ToList();
        }

        public IEnumerable<HoaDon> GetHoaDonHuy()
        {
            return petContext.HoaDons.Where(m => m.IdTrangThai==4).ToList();
        }

        public IEnumerable<LoaiThuCung> GetLoai()
        {
            return petContext.loaiThuCungs.ToList();
        }

        public IEnumerable<KhachHang> GetNhanVien()
        {
            return petContext.KhachHangs.ToList();
        }

        public IEnumerable<ThuCung> GetThuCung()
        {
            return petContext.thuCungs.ToList();
        }

        public int HDdagiao()
        {
            var hd=petContext.HoaDons.Where(m => m.IdTrangThai==7).ToList();
            return  hd.Count();
        }

        public int HDdahuy()
        {
            var hd=petContext.HoaDons.Where(m => m.IdTrangThai==4).ToList();
            return  hd.Count();
        }

        public int HDdanggiao()
        {
            var hd=petContext.HoaDons.Where(m => m.IdTrangThai==3).ToList();
            return  hd.Count();
        }

        public void HideKH(string user)
        {
            KhachHang thucung = petContext.KhachHangs.Find(user);
            thucung.TrangThai=0;
            petContext.SaveChanges();
        }

        public void HideSP(int id)
        {
            ThuCung thucung = petContext.thuCungs.Find(id);
            thucung.IsFeatured=false;
            petContext.SaveChanges();
        }

        public void ShowSP(int id)
        {
            ThuCung thucung = petContext.thuCungs.Find(id);
            thucung.IsFeatured=true;
            petContext.SaveChanges();
        }

        public void ShowKH(string user)
        {
            KhachHang thucung = petContext.KhachHangs.Find(user);
            thucung.TrangThai=1;
            petContext.SaveChanges();
        }

        public float TotalDT()
        {
            var DT=petContext.HoaDons.ToList();
            return  DT.Sum(m => m.TongTien);
        }

        public int TotalKH()
        {
            var kh=petContext.KhachHangs.ToList();
            return  kh.Count();
        }

        public int TotalLoai()
        {
            var loai=petContext.loaiThuCungs.ToList();
            return  loai.Count();
        }

        public int Totalsp()
        {
            var thucung=petContext.thuCungs.ToList();
            return  thucung.Count();
        }

        public IEnumerable<NhanVien> GetNhanVienn()
        {
            return petContext.NhanViens.ToList();
        }

        public NhanVien GetByNV(string id)
        {
            return petContext.NhanViens.Find(id);
        }

        public void HideNV(string user)
        {
            NhanVien thucung = petContext.NhanViens.Find(user);
            thucung.TrangThai=0;
            petContext.SaveChanges();
        }

        public void ShowNV(string user)
        {
            NhanVien thucung = petContext.NhanViens.Find(user);
            thucung.TrangThai=1;
            petContext.SaveChanges();
        }

        public void AddNV(NhanVien loai)
        {
            petContext.NhanViens.Add(loai);
            petContext.SaveChanges();
        }

        public IEnumerable<HoaDon> Filter()
        {
           return petContext.HoaDons.OrderByDescending(m => m.NgayLap).ToList();
        }

        public float TotalChi()
        {
            var DT=petContext.thuCungs.ToList();
            return  DT.Sum(m => m.GiaNhap);
        }
    }
}