using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Domain.Interfaces;

namespace Domain.Entities
{
    public class OnSaleDetail: IAggregateRoot
    {
        [DisplayName("Id")]
        [Key]
        public int IdOnSaleDetail { get; set; }
        [Required]
        public ThuCung ThuCung { get; set; }
        [Required]
        public OnSale OnSale { get; set; }
    }
}