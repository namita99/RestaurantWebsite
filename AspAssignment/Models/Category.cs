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
        [Display(Name = "Category ID")]
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "{0} cannot be Empty!")]
        [Display(Name = "Category Name")]
        [MinLength(4, ErrorMessage = "{0} should have at least {1} characters")]
        [MaxLength(100, ErrorMessage = "{0} should have maximum {1} characters")]
        public string CategoryName { get; set; }

        [Required(ErrorMessage = "{0} cannot be Empty!")]
        [Display(Name = "Description of the Category")]
        [MinLength(4, ErrorMessage = "{0} should have at least {1} characters")]
        [MaxLength(100, ErrorMessage = "{0} should have maximum {1} characters")]
        public string CategoryDescription { get; set; }

        [Required(ErrorMessage = "{0} cannot be Empty!")]
        [DefaultValue(1)]
        [Display(Name = "Category Price")]
        public int Price { get; set; }


        [Required]
        [DefaultValue(1)]
        public short Quantity { get; set; }

        #region Navigation Properties to the Order Model

        public ICollection<Order> Orders { get; set; }

     
        #endregion
    }
}
