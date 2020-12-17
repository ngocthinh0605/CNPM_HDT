using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Test
    {
        [Key]
        public int IdChiTietHD { get; set; }
        public int IdThuCung { get; set; }
        public int IdHoaDon { get; set; }
        public float ThanhTien { get; set; }
        public int SoLuong { get; set; }
    }
}