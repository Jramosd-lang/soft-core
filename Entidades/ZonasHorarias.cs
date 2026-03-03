using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades
{
    [Table("zonas_horarias")]
    public class ZonaHoraria
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        [Column("nombre_iana")]
        public string NombreIana { get; set; } = string.Empty;

        // 🔥 Relación 1-N

        public ICollection<Ciudad> Ciudades { get; set; }
            = new List<Ciudad>();
    }
}