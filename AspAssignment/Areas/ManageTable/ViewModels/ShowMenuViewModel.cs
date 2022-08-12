using AspAssignment.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AspAssignment.Areas.ManageTable.ViewModels
{
    public class ShowMenuViewModel
    {
        [Required(ErrorMessage = "{0} cannot be empty")]
        [Display(Name = "Category")]
        public int CategoryId { get; set; }


        public ICollection<Order> Orders { get; set; }

        public int? Quantity { get; set; }
    }
}
