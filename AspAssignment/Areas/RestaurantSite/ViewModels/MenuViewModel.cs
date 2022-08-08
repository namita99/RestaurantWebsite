using AspAssignment.Models;
using System.ComponentModel.DataAnnotations;

namespace AspAssignment.Areas.RestaurantSite.ViewModels
{
    public class MenuViewModel:Menu
    {
        [Display(Name = "Dish ID")]
        override public int DishId 
        {
            get
            {
                return base.DishId;
            }
            set
            {
                base.DishId = value;
            }
        }
        [Display(Name = "Image of the Dish")]
        public override string ImageUrl
        {
            get => base.ImageUrl;
            set => base.ImageUrl = value;
        }
            
        [Display(Name = "Dish Name")]
        [Required(ErrorMessage = "{0} cannot be Empty!")]
        [MinLength(4, ErrorMessage = "{0} should have at least {1} characters")]
        [MaxLength(100, ErrorMessage = "{0} should have maximum {1} characters")]

        override public string DishName
        { 
            get => base.DishName; 
            set => base.DishName = value;
        }

        [Display(Name = "Description of the Dish")]
        [Required(ErrorMessage = "{0} cannot be Empty!")]
        [MinLength(3, ErrorMessage = "{0} should have at least {1} characters")]
        [MaxLength(100, ErrorMessage = "{0} should have maximum {1} characters")]

        override public string Description
        {
            get => base.Description;
            set => base.Description = value;
        }
        [Display(Name = "Dish Price")]
        override public int Price
        {
            get
            {
                return base.Price;
            }
            set
            {
                base.Price = value;
            }
        }
        [Display(Name = "Quantity")]
        override public short Quantity
        {
            get => base.Quantity;
            set => base.Quantity = value;
        }

        

    }
}
