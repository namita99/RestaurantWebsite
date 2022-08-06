using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AspAssignment.Models
{
    [Table(name: "Categories")]
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryId { get; set; }

        [Required]
        [StringLength(100)]
        public string CategoryName { get; set; }

        [Required]
        [StringLength(100)]
        public string CategoryDescription { get; set; }

        [Required]
        [DefaultValue(1)]
        public int Price { get; set; }


        [Required]
        [DefaultValue(1)]
        public short Quantity { get; set; }

        #region Navigation Properties to the Order Model

        public ICollection<Order> Orders { get; set; }

     
        #endregion
    }
}
