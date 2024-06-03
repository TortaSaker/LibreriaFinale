using System.ComponentModel.DataAnnotations;

namespace LibreriaFinale.Model.Dto
{
    public class LibroDTO
    {
        [Required]
        [MaxLength(13)]
        [MinLength(10)]
        public string ISBN { get; set; }
        public string Titolo { get; set; }
        public string Autore { get; set; }
        public string Genere { get; set; }
        public string Anno { get; set; }
    }
}
