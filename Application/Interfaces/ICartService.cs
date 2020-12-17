using System.Collections.Generic;
using Application.DTOs;

namespace Application.Interfaces
{
    public interface ICartService
    {
        IEnumerable<LoaiThuCungDTO> GetAll();
        void AddCartToDB(int IdThuCung,int Quantity,string UserName);
        void UpdateToDB(string username,int Id,int Quantity);

         ThuCungDTO GetThuCungToCart(int Id);
          IEnumerable<CartDBDTO> GetCart(string UserName);
          IEnumerable<CartDBDTO> GetCheckOut(string UserName);
        IEnumerable<ThuCungDTO> GetThuCung();
        IEnumerable<CartDBDTO> GetCartNe(string username, int id);
        int GetSl(string username, int id);
        void RemoveCartToDB(int IdThuCung,string UserName);
         bool CheckTaiKhoan(string username,int id);
         

    }
}