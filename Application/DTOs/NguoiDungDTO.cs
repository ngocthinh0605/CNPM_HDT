using System.ComponentModel.DataAnnotations;

namespace Application.DTOs
{
    public class NguoiDungDTO
    {
         [Key]
        public string UserName { get; set; }
      
       
        [Display(Name = "Mật Khẩu")]
        //[RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,15}$")]
        [Required(ErrorMessage = "Mật Khẩu Không Được Để Trống")]
        public string MatKhau { get; set; }

        [Display(Name = "Xác Nhận Mật Khẩu")]
        [Compare("MatKhau", ErrorMessage = "Xác Nhận Mật Khẩu Không Đúng")]
        public string ConfirmMatKhau { get; set; }
        [Required(ErrorMessage="Tên người dùng không được bỏ trống")]
        [MaxLength(20,ErrorMessage="Tên người dùng không vượt quá 20 ký tự")]
        public string TenUser { get; set; }
        [Required(ErrorMessage="Mật khẩu không được bỏ trống")]
        // [RegularExpression(@"((09|03|07|08|05)+([0-9]{8})\b)", ErrorMessage = "Số điện thoại không đúng định dạng")]
        public int SoDienThoai { get; set; }
        [Required(ErrorMessage="Địa chỉ không được bỏ trống")]
        [MaxLength(200)]
        public string DiaChi { get; set; }
        [Required(ErrorMessage = "Giới tính không được bỏ trống")]
        
        public string GioiTinh { get; set; }
        [Required(ErrorMessage = "Email không được bỏ trống")]
        [DataType(DataType.EmailAddress)]
        [MaxLength(50)]
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Chưa nhập đúng định dạng Email")]
        public string Email { get; set; }
         public int TrangThai{get; set;}
    }
}