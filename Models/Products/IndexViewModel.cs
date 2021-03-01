using System.ComponentModel.DataAnnotations;

namespace MVC.Models.Products
{
    public class IndexViewModel
    {
        [Required(ErrorMessage = "Please Add Name")]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Range (0, 100)]
        public int Age { get; set; }

        [Required]
        public string Address { get; set; }
    }
}