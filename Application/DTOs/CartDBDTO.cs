using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Application.DTOs
{
    public class CartDBDTO
    {
        [Key]
        public int CartId { get; set; }
        public int Id { get; set; }  
      
        public string User { get; set; }
        public int Quantity { get; set; }
        public string TenThuCung { get; set; }
        public string image { get; set; }
        public float DonGia { get; set; }


        public SelectListItem Emps { get; set; }   
    }
}