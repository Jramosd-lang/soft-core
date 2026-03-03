using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades
{
    [Table("items_orden_compra")]
    public class ItemOrdenCompra
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("cantidad_ordenada")]
        public int CantidadOrdenada { get; set; }

        [Column("cantidad_recibida")]
        public int CantidadRecibida { get; set; }

        [Column("costo_unitario", TypeName = "numeric(12,2)")]
        public decimal CostoUnitario { get; set; }

        [Column("subtotal_monto", TypeName = "numeric(12,2)")]
        public decimal? SubtotalMonto { get; set; }

        [Column("fecha_recepcion")]
        public DateTime? FechaRecepcion { get; set; }

        [Column("orden_compra_id")]
        public int OrdenCompraId { get; set; }

        [Column("variante_id")]
        public int VarianteId { get; set; }

        // 🔥 Navegación

        public OrdenCompra OrdenCompra { get; set; } = null!;

        public VarianteProducto Variante { get; set; } = null!;

        public ICollection<RecepcionCompra> RecepcionesCompra { get; set; }
            = new List<RecepcionCompra>();
    }
}