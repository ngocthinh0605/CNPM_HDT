using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Domain.Interfaces;

namespace Domain.Entities
{
    public class Role:IAggregateRoot
    {
        [DisplayName("Id")]
        [Key]
        public int IdRole { get; set; }
        
        [Required(ErrorMessage="Tên quyền không được bỏ trống")]
        [MaxLength(20)]
        public string TenRole { get; set; }
    }
}