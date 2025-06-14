using System.ComponentModel.DataAnnotations;

namespace NorthWind.Modelos
{
    public class WebTracker
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string UrlRequest { get; set; }
        [Required]
        public string SourceIp { get; set; }
        [Required]
        public DateTime TimeOfAction { get; set; }
    }
}
