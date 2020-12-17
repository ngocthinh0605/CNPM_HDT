using System.ComponentModel.DataAnnotations;
using Domain.Interfaces;

namespace Domain.Entities
{
    public class Tempt: IAggregateRoot
    {
        [Key]
        public int id { get; set; }
        public int IdHoaDon { get; set; }
        public int IdThuCung { get; set; }
        public int SoLuong { get; set; }

    }
}