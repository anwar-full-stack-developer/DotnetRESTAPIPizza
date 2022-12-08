using System.ComponentModel.DataAnnotations;

namespace DotnetRESTAPIPizza.Models
{
    public class Pizzaa
    {
        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        public string? Name { get; set; }

        public bool IsGlutenFree { get; set; }

        [Required]
        [StringLength(30)]
        public string? Recipe { get; set; }


        [Required]
        [StringLength(150)]
        public string? Ingredients { get; set; }
    }


}