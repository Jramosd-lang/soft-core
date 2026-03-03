using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades
{
    [Table("movimientos_inventario")]
    public class MovimientoInventario
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        [Column("tipo_movimiento")]
        public string TipoMovimiento { get; set; } = string.Empty;

        [Column("cantidad")]
        public int Cantidad { get; set; }

        [Column("costo_promedio_unitario", TypeName = "numeric(10,2)")]
        public decimal? CostoPromedioUnitario { get; set; }

        [Column("fecha_movimiento")]
        public DateTime FechaMovimiento { get; set; }

        [MaxLength(30)]
        [Column("tipo_referencia")]
        public string? TipoReferencia { get; set; }

        [Column("observaciones")]
        public string? Observaciones { get; set; }

        [Column("existencia_id")]
        public int ExistenciaId { get; set; }

        [Column("usuario_id")]
        public int UsuarioId { get; set; }

        // 🔥 Navegación

        public ExistenciaInventario Existencia { get; set; } = null!;

        public Usuario Usuario { get; set; } = null!;
    }
}