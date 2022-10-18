using System.ComponentModel.DataAnnotations;

namespace CorrectifCrud.Models
{
    public class GameFormModel
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Genre { get; set; }
    }
}
