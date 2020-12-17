

using System.Collections.Generic;
using Application.DTOs;

namespace mvcPet.Models
{
    public class ChiTietHoaDonViewModel
    {
        public IEnumerable<TemptDTO> GetCTHD { get; set; }
        public IEnumerable<ThuCungDTO> GetThuCungg { get; set; }
        public IEnumerable<ThuCungDTO> GetThuCung { get; set; }
        public IEnumerable<CartDBDTO> GetCart { get; set; }
        public IEnumerable<LoaiThuCungDTO> GetAllLoai{ get; set; }
    }
}