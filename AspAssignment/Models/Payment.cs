using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AspAssignment.Models
{
    [Table(name: "Payments")]

    public class Payment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Payement ID")]
        public int PaymentId { get; set; }

        [Required(ErrorMessage = "{0} cannot be Empty!")]
        [MinLength(3, ErrorMessage = "{0} should have at least {1} characters")]
        [MaxLength(100, ErrorMessage = "{0} should have maximum {1} characters")]
        [Display(Name = "Payment Type")]
        public string PaymentType { get; set; }

        [Required(ErrorMessage = "{0} cannot be Empty!")]
        [DefaultValue(1)]
        [Display(Name = "Total Payment")]
         public int Price { get; set; }


        [Required(ErrorMessage = "{0} cannot be Empty!")]
        [MinLength(3, ErrorMessage = "{0} should have at least {1} characters")]
        [MaxLength(100, ErrorMessage = "{0} should have maximum {1} characters")]
        [Display(Name = "Payment Status")]
        public string PaymentStatus { get; set; }

        [Required]
        [DefaultValue(false)]
        [Display(Name = "Payment Done")]

        public bool IsEnabled { get; set; }


        #region Navigation Properties to the Category Model

        [Display(Name = "Customer Name")]

        public int CustomerId { get; set; }


        [ForeignKey(nameof(Payment.CustomerId))]
        public Customer Customer { get; set; }

        #endregion

      
    }
}
