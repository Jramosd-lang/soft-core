using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades
{
    [Table("paises")]
    public class Pais
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        [Column("nombre")]
        public string Nombre { get; set; } = string.Empty;

        // 🔥 Relación 1-N

        public ICollection<Departamento> Departamentos { get; set; }
            = new List<Departamento>();
    }
}