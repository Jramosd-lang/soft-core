using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades
{
    [Table("usuarios")]
    public class Usuario
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        [Column("primer_nombre")]
        public string PrimerNombre { get; set; } = string.Empty;

        [MaxLength(20)]
        [Column("segundo_nombre")]
        public string? SegundoNombre { get; set; }

        [Required]
        [MaxLength(20)]
        [Column("primer_apellido")]
        public string PrimerApellido { get; set; } = string.Empty;

        [MaxLength(20)]
        [Column("segundo_apellido")]
        public string? SegundoApellido { get; set; }

        [Required]
        [MaxLength(254)]
        [Column("correo")]
        public string Correo { get; set; } = string.Empty;

        [Required]
        [MaxLength(15)]
        [Column("telefono")]
        public string Telefono { get; set; } = string.Empty;

        [Required]
        [MaxLength(255)]
        [Column("contrasena_hash")]
        public string ContrasenaHash { get; set; } = string.Empty;

        [Required]
        [MaxLength(20)]
        [Column("rol")]
        public string Rol { get; set; } = string.Empty;

        [Required]
        [MaxLength(20)]
        [Column("estado")]
        public string Estado { get; set; } = string.Empty;

        [Column("fecha_creacion")]
        public DateTime FechaCreacion { get; set; }

        [Column("ultimo_acceso")]
        public DateTime? UltimoAcceso { get; set; }

        [Column("ubicacion_asignada_id")]
        public int? UbicacionAsignadaId { get; set; }

        // 🔥 Navegación

        public Ubicacion? UbicacionAsignada { get; set; }

        public ICollection<OrdenTrabajo> OrdenesTrabajo { get; set; }
            = new List<OrdenTrabajo>();

        public ICollection<OrdenCompra> OrdenesCompra { get; set; }
            = new List<OrdenCompra>();

        public ICollection<MovimientoInventario> MovimientosInventario { get; set; }
            = new List<MovimientoInventario>();

        public ICollection<RecepcionCompra> RecepcionesCompra { get; set; }
            = new List<RecepcionCompra>();
    }
}