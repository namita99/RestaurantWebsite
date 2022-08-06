using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AspAssignment.Models
{
    [Table(name: "Customers")]

    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CustomerId { get; set; }

        [Required]
        [StringLength(100)]
        public string CustomerName { get; set; }

        [Required]
        [StringLength(100)]
        public string CustomerAddress { get; set; }


        [Required]
        [DefaultValue(1)]
        public int CustomerNo { get; set; }


      

        #region Navigation Properties to the Order Model


        public ICollection<Order> Orders { get; set; }

        public ICollection<Payment> Payments { get; set; }



        #endregion

    }
}
