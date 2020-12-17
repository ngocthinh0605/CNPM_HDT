using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Application.DTOs
{
    public class TrangThaiDTO
    {
        [DisplayName("Id")]
        [Key]
        public int IdTrangThai { get; set; }
        [Required(ErrorMessage="Tên trạng thái không được bỏ trống")]
        [MaxLength(40)]
        public string TenTrangThai { get; set; }
    }
}