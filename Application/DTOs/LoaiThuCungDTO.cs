using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace Application.DTOs
{
    public class LoaiThuCungDTO
    {
        [DisplayName("Id")]
        [Key]
        public int IdLoaiThuCung { get; set; }

        [Required(ErrorMessage="Không được bỏ trống tên")]
        [MaxLength(30)]
        public string TenLoai { get; set; }
        [Required(ErrorMessage="Không được bỏ trống số lượng")]
        [Range(0, 1000000000000, ErrorMessage = "Số lượng từ 0 đến 1000000000000")]
        public int SoLuong { get; set; }
        [Required(ErrorMessage="Không được bỏ trống tập tính")]
        [MaxLength(300)]
        public string TapTinh { get; set; }
        [Required(ErrorMessage="Không được bỏ trống cách nuôi")]
        public string CachNuoi { get; set; }
        [Required(ErrorMessage="Không được bỏ trống tuổi thọ")]
        public string TuoiTho { get; set; }
        [Required(ErrorMessage="Không được bỏ trống ngoại hình")]
        [MaxLength(300)]
        public string NgoaiHinh { get; set; }
         
        public string Description { get; set; }
        public string Image { get; set; } 
    }
}