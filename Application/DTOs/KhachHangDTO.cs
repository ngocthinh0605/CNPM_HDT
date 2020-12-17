using System.Collections.Generic;

namespace Application.DTOs
{
    public class KhachHangDTO: NguoiDungDTO
    {
         
           public IEnumerable<LoaiThuCungDTO> GetAllLoai{ get; set; }
             public IEnumerable<ThuCungDTO> GetThuCung { get; set; }
            public IEnumerable<CartDBDTO> GetCart { get; set; }
    }
}