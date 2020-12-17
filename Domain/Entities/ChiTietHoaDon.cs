using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Domain.Interfaces;

namespace Domain.Entities
{
    public class ChiTietHoaDon: IAggregateRoot
    {
        [DisplayName("Id")]
        [Key]
        public int IdChiTietHD { get; set; }
        
        [DisplayName("Id Thu Cung")]
        [Required(ErrorMessage="Không được bỏ trống")]
        public int IdThuCung { get; set; }
         [DisplayName("Id Hoa Don")]
        [Required(ErrorMessage="Không được bỏ trống")]
        public int IdHoaDon { get; set; }
        public float ThanhTien { get; set; }
        public int SoLuong { get; set; }

    }
}