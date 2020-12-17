using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Domain.Interfaces;

namespace Domain.Entities
{
    public class TrangThai: IAggregateRoot
    {
        [DisplayName("Id")]
        [Key]
        public int IdTrangThai { get; set; }
        [Required(ErrorMessage="Tên trạng thái không được bỏ trống")]
        [MaxLength(40)]
        public string TenTrangThai { get; set; }
    }
}