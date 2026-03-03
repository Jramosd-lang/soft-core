using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades
{
    [Table("items_orden_trabajo")]
    public class ItemOrdenTrabajo
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        [Column("descripcion")]
        public string Descripcion { get; set; } = string.Empty;

        [Column("cantidad")]
        public int Cantidad { get; set; }

        [Column("precio_unitario", TypeName = "numeric(12,2)")]
        public decimal PrecioUnitario { get; set; }

        [Column("descuento_monto", TypeName = "numeric(12,2)")]
        public decimal? DescuentoMonto { get; set; }

        [Column("subtotal_monto", TypeName = "numeric(12,2)")]
        public decimal? SubtotalMonto { get; set; }

        [Required]
        [MaxLength(30)]
        [Column("estado")]
        public string Estado { get; set; } = string.Empty;

        [Column("orden_trabajo_id")]
        public int OrdenTrabajoId { get; set; }

        // 🔥 Navegación

        public OrdenTrabajo OrdenTrabajo { get; set; } = null!;
    }
}