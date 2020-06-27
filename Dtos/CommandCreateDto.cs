using System.ComponentModel.DataAnnotations;

namespace PowerliftingREST.Dtos
{
    public class CommandCreateDto
    {
        public string Id { get; set; }
        
        [Required]
        [MaxLength(250)]
        public string HowTo { get; set; }

        [Required]
        public string Line { get; set; }

        [Required]
        public string Platform { get; set; }
    }
}