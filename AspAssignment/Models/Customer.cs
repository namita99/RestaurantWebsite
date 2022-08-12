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
        [Display(Name = "Customer ID")]

        public int CustomerId { get; set; }

        [Required(ErrorMessage = "{0} cannot be Empty!")]
        [Display(Name = "Customer Name")]
        [MinLength(4, ErrorMessage = "{0} should have at least {1} characters")]
        [MaxLength(100, ErrorMessage = "{0} should have maximum {1} characters")]
        public string CustomerName { get; set; }

        [Required(ErrorMessage = "{0} cannot be Empty!")]
        [StringLength(100)]
        [Display(Name = "Customer Address")]
        [MinLength(4, ErrorMessage = "{0} should have at least {1} characters")]
        [MaxLength(100, ErrorMessage = "{0} should have maximum {1} characters")]
        public string CustomerAddress { get; set; }


        [Required(ErrorMessage = "{0} cannot be Empty!")]
        [DefaultValue(1)]
        [Display(Name = "Customer Number")]

        public int CustomerNo { get; set; }


      

        #region Navigation Properties to the Order Model


        public ICollection<Order> Orders { get; set; }

        public ICollection<Payment> Payments { get; set; }

       

        #endregion

    }
}
