using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Application.DTOs
{
    public class ChiTietHoaDonDTO
    {
       
        public int IdChiTietHD { get; set; }
        
               public int IdThuCung { get; set; }
                public int IdHoaDon { get; set; }
        public float ThanhTien { get; set; }
        public int SoLuong { get; set; }
    }
}