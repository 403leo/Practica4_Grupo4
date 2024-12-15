using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class Chiste
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        [StringLength(100)]
        public string Description { get; set; }
    }
}