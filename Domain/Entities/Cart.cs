using System.ComponentModel.DataAnnotations;
using Domain.Interfaces;

namespace Domain.Entities
{
    public class Cart: IAggregateRoot
    {
        public ThuCung _thucung { get; set; }
        public int _Quantity { get; set; }
        public KhachHang  username { get; set; }
    }
}