using AspAssignment.Models;
using System.ComponentModel.DataAnnotations;

namespace AspAssignment.Areas.RestaurantSite.ViewModels
{
    public class OrderViewModel : Order
    {
        [Display(Name = "Order ID")]
        override public int OrderId
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

        [Display(Name = "Order Status")]
        [Required(ErrorMessage = "{0} cannot be Empty!")]
        [MinLength(3, ErrorMessage = "{0} should have at least {1} characters")]
        [MaxLength(100, ErrorMessage = "{0} should have maximum {1} characters")]

        override public string OrderStatus
        {
            get => base.OrderStatus;
            set => base.OrderStatus = value;
        }

        [Display(Name = "Table Name")]
        [Required(ErrorMessage = "{0} cannot be Empty!")]
        [MinLength(3, ErrorMessage = "{0} should have at least {1} characters")]
        [MaxLength(100, ErrorMessage = "{0} should have maximum {1} characters")]

        override public string TableName
        {
            get => base.TableName;
            set => base.TableName = value;
        }

        [Display(Name = "Quantity")]
        override public short Quantity
        {
            get => base.Quantity;
            set => base.Quantity = value;
        }

        [Display(Name = "Category Name")]
        override public int CategoryId
        {
            get
            {
                return base.CategoryId;
            }
            set
            {
                base.CategoryId = value;
            }
        }

        [Display(Name = "Dish Name")]
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

        [Display(Name = "Customer Name")]
        override public int CustomerId
        {
            get
            {
                return base.CustomerId;
            }
            set
            {
                base.CustomerId = value;
            }
        }






    }
}
