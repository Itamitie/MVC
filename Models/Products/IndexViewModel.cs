using System.ComponentModel.DataAnnotations;

namespace MyWork.Models.Products
{
    public class IndexViewModel
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Range (0, 100)]
        public int Age { get; set; }
    }
}