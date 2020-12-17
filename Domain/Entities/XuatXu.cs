using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Domain.Interfaces;

namespace Domain.Entities
{
    public class XuatXu: IAggregateRoot
    {
        [DisplayName("Id")]
        [Key]
        public int IdXuatXu { get; set; }
        
        [Required(ErrorMessage="Tên xuất xứ không được bỏ trống")]
        [MaxLength(35)]
        public string TenXuatXu { get; set; }
    }
}