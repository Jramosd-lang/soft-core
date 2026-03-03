using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades
{
    [Table("existencias_inventario")]
    public class ExistenciaInventario
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("cantidad_disponible")]
        public int CantidadDisponible { get; set; }

        [Column("cantidad_reservada")]
        public int CantidadReservada { get; set; }

        [Column("costo_promedio_unitario", TypeName = "numeric(10,2)")]
        public decimal? CostoPromedioUnitario { get; set; }

        [Column("stock_minimo")]
        public int? StockMinimo { get; set; }

        [Column("stock_maximo")]
        public int? StockMaximo { get; set; }

        [Column("fecha_actualizacion")]
        public DateTime FechaActualizacion { get; set; }

        [Column("variante_id")]
        public int VarianteId { get; set; }

        [Column("ubicacion_id")]
        public int UbicacionId { get; set; }

        // 🔥 Navegación

        public VarianteProducto Variante { get; set; } = null!;

        public Ubicacion Ubicacion { get; set; } = null!;

        public ICollection<MovimientoInventario> MovimientosInventario { get; set; }
            = new List<MovimientoInventario>();
    }
}