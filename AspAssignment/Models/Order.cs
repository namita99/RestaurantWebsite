using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AspAssignment.Models
{
    [Table(name: "Orders")]
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Order ID")]
        public int OrderId { get; set; }


        [Required(ErrorMessage = "{0} cannot be Empty!")]
        [MinLength(4, ErrorMessage = "{0} should have at least {1} characters")]
        [MaxLength(100, ErrorMessage = "{0} should have maximum {1} characters")]
        [Display(Name = "Order Status")]
        public string OrderStatus { get; set; }

        [Required]
        [DefaultValue(1)]
        public short Quantity { get; set; }

        #region Navigation Properties to the Category Model

        public int CategoryId { get; set; }


        [ForeignKey(nameof(Order.CategoryId))]

     
        public Category Category { get; set; }

        public int DishId { get; set; }


        [ForeignKey(nameof(Order.DishId))]
        public Menu Menu { get; set; }

        public int CustomerId { get; set; }


        [ForeignKey(nameof(Order.CustomerId))]
        public Customer Customer { get; set; }



        #endregion
    }
}
