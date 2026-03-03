using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades
{
    [Table("ubicaciones")]
    public class Ubicacion
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [MaxLength(40)]
        [Column("nombre")]
        public string Nombre { get; set; } = string.Empty;

        [Required]
        [MaxLength(30)]
        [Column("tipo_ubicacion")]
        public string TipoUbicacion { get; set; } = string.Empty;

        [Required]
        [MaxLength(20)]
        [Column("estado")]
        public string Estado { get; set; } = string.Empty;

        [Column("es_principal")]
        public bool EsPrincipal { get; set; }

        [Column("direccion_id")]
        public int DireccionId { get; set; }

        // 🔥 Navegación

        public Direccion Direccion { get; set; } = null!;

        public ICollection<OrdenCompra> OrdenesCompraDestino { get; set; }
            = new List<OrdenCompra>();

        public ICollection<ExistenciaInventario> ExistenciasInventario { get; set; }
            = new List<ExistenciaInventario>();

        public ICollection<Usuario> Usuarios { get; set; }
            = new List<Usuario>();
    }
}