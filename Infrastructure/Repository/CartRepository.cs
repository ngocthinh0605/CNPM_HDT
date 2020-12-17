using System.Collections.Generic;
using System.Linq;
using Domain.Entities;
using Domain.Repository;
using Infrastructure.Persistence;

namespace Infrastructure.Repository
{
    public class CartRepository : ICartRepository
    {
        private readonly PetContext petContext;
       
        public CartRepository(PetContext petContext)
        {
            this.petContext=petContext;
        }

       
         public ThuCung GetThuCungToCart(int Id)
        {
            return petContext.thuCungs.Where(m=> m.IdThuCung==Id).FirstOrDefault();
        }

        public IEnumerable<LoaiThuCung> GetLoai()
        {
             return petContext.loaiThuCungs.ToList();
        }

        public void AddCartToDB(int IdThuCung,int Quantity,string UserName)
        {
            
            var cart = new CartDB()
            {
                Id =IdThuCung,
                Quantity=Quantity,
                User= UserName
            };
            petContext.Carts.Add(cart);
            petContext.SaveChanges();
        }

        public void UpdateToDB(string username,int Id, int Quantity)
        {
            CartDB cart = petContext.Carts.Single(p => p.Id==Id && p.User== username);
                cart.Quantity=Quantity;
                petContext.SaveChanges();
        }

        public IEnumerable<CartDB> GetCart(string UserName)
        {
           return petContext.Carts.Where(m => m.User==UserName).ToList();
        }

        public IEnumerable<ThuCung> GetThuCung()
        {
            return petContext.thuCungs.ToList();
        }

        public IEnumerable<CartDB> GetCartNe(string username, int id)
        {
            return petContext.Carts.Where(m => m.Id==id && m.User==username).ToList();
        }

        public int GetSl(string username, int id)
        {
            if(CheckTaiKhoan(username,id))
            {
                var sl = petContext.Carts.Single(m => m.User==username && m.Id==id);
                return sl.Quantity;
            }
           return 0;
            // return 0;
         }

        public void RemoveCartToDB(int IdThuCung, string UserName)
        {
           CartDB cart =petContext.Carts.Single(p => p.Id==IdThuCung && p.User== UserName);
            petContext.Carts.Remove(cart);
            petContext.SaveChanges();
        }

        public bool CheckTaiKhoan(string username, int id)
        {
            return petContext.Carts.Where(x => x.User==username && x.Id==id).Count() >0;
        }

        public IEnumerable<CartDB> GetCheckOut(string UserName)
        {
            return petContext.Carts.Where(m => m.User==UserName ).ToList();
        }

        
    }
}