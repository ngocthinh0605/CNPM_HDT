using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class NhanVien: NguoiDung
    {
        [Required]
        public int IdRole1 { get; set; }
    }
}