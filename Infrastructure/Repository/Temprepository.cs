using System.Collections.Generic;
using System.Linq;
using Domain.Entities;
using Domain.Repository;
using Infrastructure.Persistence;

namespace Infrastructure.Repository
{
    public class Temprepository : ITemprepository
    {
        private readonly PetContext petContext;
        public Temprepository(PetContext petContext)
        {
            this.petContext=petContext;
        }

        public void Add(Tempt tempt)
        {
             petContext.Temp.Add(tempt);
            petContext.SaveChanges();
        }

        public IEnumerable<Tempt> GetChiTietHoaDons(int idhoadon)
        {
            return petContext.Temp.Where(m => m.IdHoaDon==idhoadon).ToList();
        }
        public IEnumerable<ThuCung> GetThuCungs()
        {
             return petContext.thuCungs.ToList();
        }
    }
}