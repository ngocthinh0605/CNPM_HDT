namespace Application.DTOs
{
    public class CartDTO
    {
        public ThuCungDTO thucung { get; set; }
        public int Quantity { get; set; }

        public KhachHangDTO khachHang {get; set;}
    }
}