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
        public int DishId { get; set; }

        [Required]
        [StringLength(100)]
        public string DishName { get; set; }

        [Required]
        [StringLength(100)]
        public string Description { get; set; }

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
