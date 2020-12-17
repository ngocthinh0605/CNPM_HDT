using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Domain.Interfaces;

namespace Domain.Entities
{
    public class OnSale:  IAggregateRoot
    {
        [DisplayName("Id")]
        [Key]
        public int IdOnSale { get; set; }
        
        [Required(ErrorMessage="Gia không được bỏ trống")]
        [Range(0, 100000, ErrorMessage = "Gía giảm từ 0 đến 100000")]
        public float GiaGiam { get; set; }

        [DataType(DataType.DateTime)]
        [Required(ErrorMessage="Không được bỏ trống ngày bắt đầu")]
        public DateTime NgayBD { get; set; }

        [DataType(DataType.DateTime)]
        [Required(ErrorMessage="Không được bỏ trống ngày keestb thúc")]
        public DateTime NgayKT { get; set; }
    }
}