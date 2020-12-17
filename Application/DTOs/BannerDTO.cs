using System.ComponentModel.DataAnnotations;

namespace Application.DTOs
{
    public class BannerDTO
    {
         [Required(ErrorMessage="Không được bỏ trống tên")]
        [MaxLength(30)]
        public string TenLoai { get; set; }
         [Required(ErrorMessage="Bạn chưa nhập tên ảnh")]
        public string Image { get; set; }
         [Required(ErrorMessage="Không được bỏ trống miêu tả")]
        public string Description { get; set; }
    }
}