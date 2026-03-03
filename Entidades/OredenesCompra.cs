using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades
{
    [Table("ordenes_compra")]
    public class OrdenCompra
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        [Column("numero")]
        public string Numero { get; set; } = string.Empty;

        [Required]
        [MaxLength(30)]
        [Column("estado")]
        public string Estado { get; set; } = string.Empty;

        [Column("fecha_creacion")]
        public DateTime FechaCreacion { get; set; }

        [Column("fecha_estimada_recepcion")]
        public DateTime? FechaEstimadaRecepcion { get; set; }

        [Column("subtotal_monto", TypeName = "numeric(12,2)")]
        public decimal? SubtotalMonto { get; set; }

        [Column("impuestos_monto", TypeName = "numeric(12,2)")]
        public decimal? ImpuestosMonto { get; set; }

        [Column("gastos_envio", TypeName = "numeric(12,2)")]
        public decimal? GastosEnvio { get; set; }

        [Column("total_monto", TypeName = "numeric(12,2)")]
        public decimal? TotalMonto { get; set; }

        [Column("condiciones_pago")]
        public string? CondicionesPago { get; set; }

        [Column("proveedor_id")]
        public int ProveedorId { get; set; }

        [Column("ubicacion_destino_id")]
        public int UbicacionDestinoId { get; set; }

        [Column("usuario_id")]
        public int UsuarioId { get; set; }

        // 🔥 Navegación

        public Proveedor Proveedor { get; set; } = null!;

        public Ubicacion UbicacionDestino { get; set; } = null!;

        public Usuario Usuario { get; set; } = null!;

        public ICollection<ItemOrdenCompra> ItemsOrdenCompra { get; set; }
            = new List<ItemOrdenCompra>();
    }
}