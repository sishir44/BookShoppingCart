using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookShoppingCartMvcUI.Models
{
    [Table("Order")]
    public class Order
    {
        public int Id { get; set; }

        [Required]
        public string UserId { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

        public bool IsDeleted { get; set; } =false;

        public int OrderStatusId {  get; set; }
        public OrderStatus OrderStatus { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }
    }
}
