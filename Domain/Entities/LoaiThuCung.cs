using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Domain.Interfaces;

namespace Domain.Entities
{
    public class LoaiThuCung: IAggregateRoot
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
        public string TapTinh { get; set; }
        [Required(ErrorMessage="Không được bỏ trống cách nuôi")]
        public string CachNuoi { get; set; }
        [Required(ErrorMessage="Không được bỏ trống tuổi thọ")]
        public string TuoiTho { get; set; }
         [Required(ErrorMessage="Bạn chưa nhập tên ảnh")]
         public string Image { get; set; }
         [Required(ErrorMessage="Không được bỏ trống miêu tả")]
        public string Description { get; set; }

        [Required(ErrorMessage="Không được bỏ trống ngoại hình")]
        public string NgoaiHinh { get; set; }
        
        public int ParentId { get; set; }
    }
} 
