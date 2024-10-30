using System.ComponentModel.DataAnnotations;

namespace GamersDreamSetupC_MVC.Models
{
    public class Game
    {
        public int Id { get; set; }
        public decimal Value { get; set; }

        [Required]
        public string? Name { get; set; }
    }
}
