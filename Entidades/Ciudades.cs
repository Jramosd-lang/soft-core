using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades
{
    [Table("ciudades")]
    public class Ciudad
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        [Column("nombre")]
        public string Nombre { get; set; } = string.Empty;

        [Column("zona_horaria_id")]
        public int ZonaHorariaId { get; set; }

        [Column("departamento_id")]
        public int DepartamentoId { get; set; }

        // 🔥 Propiedades de navegación (MUY IMPORTANTES)
        public ZonaHoraria ZonaHoraria { get; set; } = null!;
        public Departamento Departamento { get; set; } = null!;
    }
}