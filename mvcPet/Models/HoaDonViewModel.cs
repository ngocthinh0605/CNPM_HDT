using System.Collections.Generic;
using Application.DTOs;

namespace mvcPet.Models
{
    public class HoaDonViewModel
    {
         public  IEnumerable<HoaDonDTO> getHoaDon { get; set; }
         
         public IEnumerable<LoaiThuCungDTO> GetAllLoai{ get; set; }
        //   List<CartDTO> GetCartItems
         public  IEnumerable<CartDTO> getCartItems { get; set; }
            public IEnumerable<CartDBDTO> GetCart { get; set; }
            public IEnumerable<CartDBDTO> GetCheckOut { get; set; }
            
            public IEnumerable<ThuCungDTO> GetThuCung { get; set; }
            public IEnumerable<TrangThaiDTO> GetTrangThai { get; set; }
            public IEnumerable<ChiTietHoaDonDTO> GetCTHD { get; set; }
        public IEnumerable<ThuCungDTO> GetThuCung1 { get; set; }

    }
}