using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Domain.Entities;
using Microsoft.AspNetCore.Http;

namespace Application.DTOs
{
    public class ThuCungDTO
    {
        [DisplayName("Id")]
        [Key]
        public int IdThuCung { get; set; }
        
        [Required(ErrorMessage="Tên thú cưng không được bỏ trống")]
        [MaxLength(35)]
        public string TenThuCung { get; set; }
        [Required(ErrorMessage="Ngày sinh không được bỏ trống")]
        [DataType(DataType.DateTime)]
        public DateTime NgaySinh { get; set; }
        [Required(ErrorMessage="Cân nặng không được bỏ trống")]
       // [DataType(DataType.Currency)]
        public float CanNang { get; set; }
        [Required(ErrorMessage="Màu lông không được bỏ trống")]
        [MaxLength(35)]
        public string MauLong { get; set; }
        [Required(ErrorMessage="Gía nhập không được bỏ trống")]
        [DataType(DataType.Currency)]
        public float GiaNhap { get; set; }
        [Required(ErrorMessage="Gía bán không được bỏ trống")]
        [DataType(DataType.Currency)]
        public float GiaBan { get; set; }
        public bool? IsFeatured { get; set; }
        public int IdLoaiThuCung{ get; set; }
        public string Image {get; set;}
        [Required(ErrorMessage = "Please choose profile image")]  
        [Display(Name = "Profile Picture")]  
        public IFormFile ProfileImage { get; set; } 
    }
}