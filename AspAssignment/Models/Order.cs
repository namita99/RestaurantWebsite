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
        public int OrderId { get; set; }


        [Required]
        [StringLength(100)]
        public string OrderStatus { get; set; }

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
