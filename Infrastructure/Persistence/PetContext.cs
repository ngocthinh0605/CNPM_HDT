using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence
{
    public partial class PetContext: DbContext
    {
        public PetContext(DbContextOptions<PetContext> options) :base(options)
        {
            
        }
        public DbSet<ThuCung> thuCungs {get; set;}
        public virtual  DbSet<LoaiThuCung> loaiThuCungs {get; set;}
        public DbSet<KhachHang> KhachHangs{ get; set; }
        public DbSet<NhanVien> NhanViens{ get; set; }
        public DbSet<HoaDon> HoaDons{ get; set; }
         public DbSet<ChiTietHoaDon> ChiTietHoaDon{ get; set; }
         public DbSet<Tempt> Temp{ get; set; }

         public DbSet<Role> Role{ get; set; }


         public DbSet<OnSale> OnSales{ get; set; }
        public DbSet<Banner> banners{ get; set; }
        public DbSet<CartDB> Carts{ get; set; }
         public DbSet<TrangThai> TrangThai{ get; set; }
         public DbSet<OnSaleDetail> OnSaleDetails{ get; set; }
    }
}