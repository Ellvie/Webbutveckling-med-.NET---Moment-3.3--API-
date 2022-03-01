using System.ComponentModel.DataAnnotations;

namespace Webbutveckling_med_.NET___Moment_3._3.Models
{
    public class Song
    {
        public int Id { get; set; }

        [Required]
        public string? Artist { get; set; }

        [Required]
        public string? Title { get; set; }

        [Required]
        public int Length { get; set; }

        [Required]
        public string? Category { get; set; }
    }
}
