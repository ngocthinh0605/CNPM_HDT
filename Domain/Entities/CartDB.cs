using System.ComponentModel.DataAnnotations;
using Domain.Interfaces;

namespace Domain.Entities
{
    public class CartDB: IAggregateRoot
    {
         [Key]
        public int CartId { get; set; }

        public int Id { get; set; }  

      
        public string User { get; set; }
        public int Quantity { get; set; }
        
    }
}