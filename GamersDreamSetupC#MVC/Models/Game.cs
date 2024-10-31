using System.ComponentModel.DataAnnotations;

namespace GamersDreamSetupC_MVC.Models
{
    public class Game
    {
        public int Id { get; set; }
        public double Value { get; set; }

        [Required]
        public string? Name { get; set; }
    }
}
