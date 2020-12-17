using System.Collections.Generic;
using Application.DTOs;
using mvcPet.Support;

namespace mvcPet.Models
{
    public class HomeViewModel
    {
           public IEnumerable<BannerDTO> banner{ get; set; }
           public IEnumerable<LoaiThuCungDTO> GetAllLoai{ get; set; }

           public IEnumerable<LoaiThuCungDTO> GetIndex4Pet{ get; set; }
           public IEnumerable<LoaiThuCungDTO> GetBest{ get; set; }
            public IEnumerable<LoaiThuCungDTO> GetFeatured{ get; set; }
            public IEnumerable<LoaiThuCungDTO> GetSale{ get; set; }
            public IEnumerable<ThuCungDTO> GetThuCungIndex {get; set;}
            public KhachHangDTO khachHang;
            public IEnumerable<ThuCungDTO> GetThuCung { get; set; }
            public IEnumerable<CartDBDTO> GetCart { get; set; }
            public string SearchString { get; set; }



    }
}