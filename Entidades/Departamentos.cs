using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades
{
    [Table("departamentos")]
    public class Departamento
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        [Column("nombre")]
        public string Nombre { get; set; } = string.Empty;

        [Column("pais_id")]
        public int PaisId { get; set; }

        // 🔥 Navegación

        public Pais Pais { get; set; } = null!;

        public ICollection<Ciudad> Ciudades { get; set; }
            = new List<Ciudad>();
    }
}