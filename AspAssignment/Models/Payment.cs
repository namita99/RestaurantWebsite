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
        public int PaymentId { get; set; }

        [Required]
        [StringLength(100)]
        public string PaymentType { get; set; }



        [Required]
        [StringLength(100)]
        public string PaymentStatus { get; set; }

        #region Navigation Properties to the Category Model

        public int CustomerId { get; set; }


        [ForeignKey(nameof(Payment.CustomerId))]
        public Customer Customer { get; set; }

        #endregion
    }
}
