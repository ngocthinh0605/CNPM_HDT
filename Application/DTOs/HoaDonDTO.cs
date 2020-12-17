using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Application.DTOs
{
    public class HoaDonDTO
    {
         [DisplayName("Id")]
        [Key]
        public int IdHoaDon { get; set; }
       
        [DataType(DataType.Date)]
        [Required(ErrorMessage="Không được bỏ trống ngày lập")]
        public DateTime NgayLap { get; set; }

        [Required(ErrorMessage="Số lượng không được để trống")]
        public int SoLuongMua { get; set; }

        [Required(ErrorMessage="STổng tiền không được để trống")]
        public float TongTien { get; set; }

        public string IdKhachHangUserName { get; set; }
        public int IdTrangThai { get; set; }

    }
}