using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AspAssignment.Models
{
    [Table(name: "Menus")]
    public class Menu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name ="Dish ID")]
        virtual public int DishId { get; set; }

        [Required(ErrorMessage ="{0} cannot be Empty!")]
        [MinLength(4, ErrorMessage = "{0} should have at least {1} characters")]
        [MaxLength(100, ErrorMessage = "{0} should have maximum {1} characters")]
        [Display(Name = " Dish Name")]
        virtual public string DishName { get; set; }

        [Required(ErrorMessage = "{0} cannot be Empty!")]
        [MinLength(4, ErrorMessage = "{0} should have at least {1} characters")]
        [MaxLength(100, ErrorMessage = "{0} should have maximum {1} characters")]
        [Display(Name = "Description of the Dish")]
        virtual public string Description { get; set; }

        [Required(ErrorMessage = "{0} cannot be Empty!")]
        [DefaultValue(1)]
        [Display(Name = "Dish Price")]
        virtual public int Price { get; set; }

        [StringLength(120)]
        virtual public string ImageUrl { get; set; } = null;


        [Required]
        [DefaultValue(1)]
         virtual public short Quantity { get; set; }

        #region Navigation Properties to the Order Model

        public ICollection<Order> Orders { get; set; }


        #endregion
    }
}
