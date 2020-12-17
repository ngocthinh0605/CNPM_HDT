using System.Collections.Generic;
using Application.DTOs;

namespace mvcPet.Models
{
    public class CartViewModel
    {
         public IEnumerable<LoaiThuCungDTO> GetAllLoai{ get; set; }
        //   List<CartDTO> GetCartItems
         public  IEnumerable<CartDTO> getCartItems { get; set; }
            public IEnumerable<CartDBDTO> GetCart { get; set; }
            public IEnumerable<CartDBDTO> GetCheckOut { get; set; }
            
            public IEnumerable<ThuCungDTO> GetThuCung { get; set; }

            List<CartDBDTO> cart {get; set;}
    }

}