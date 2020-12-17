using System.Collections.Generic;
using Domain.Entities;

namespace Domain.Repository
{
    public interface ICartRepository
    {
        IEnumerable<LoaiThuCung> GetLoai();
        IEnumerable<ThuCung> GetThuCung();
        void AddCartToDB(int IdThuCung,int Quantity,string UserName);
        void RemoveCartToDB(int IdThuCung,string UserName);

        void UpdateToDB(string username,int Id,int Quantity);


        ThuCung GetThuCungToCart(int Id);
        IEnumerable<CartDB> GetCart(string UserName);
        IEnumerable<CartDB> GetCheckOut(string UserName);


        IEnumerable<CartDB> GetCartNe(string username,int id);
        int GetSl(string username,int id);
        bool CheckTaiKhoan(string username,int id);
    }
}