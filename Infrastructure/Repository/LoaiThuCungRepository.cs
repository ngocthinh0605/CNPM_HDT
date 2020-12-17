using System.Linq;
using Domain.Entities;
using Domain.Repository;
using Infrastructure.Persistence;

namespace Infrastructure.Repository
{
    public class LoaiThuCungRepository : ILoaiThuCungRepository
    {
        private readonly PetContext petContext;
        public LoaiThuCungRepository(PetContext petContext)
        {
            this.petContext=petContext;
        }
        public void UpDateSl(int idloaithucung, int quantity)
        {
            LoaiThuCung loai= petContext.loaiThuCungs.Single(p => p.IdLoaiThuCung==idloaithucung);
            loai.SoLuong=quantity;
            petContext.SaveChanges();
        }
    }
}