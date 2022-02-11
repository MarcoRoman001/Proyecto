using System.ComponentModel.DataAnnotations;
namespace Proyecto.Models
{
    public class Pelicula
    {
        public int Id { get; set; }
        public string? Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string? Genre { get; set; }

        public string? Link1 { get; set; }

        public string? Link2 { get; set; }

        public string? Link3 { get; set; }

        public string? trailer { get; set; }
    }
}
