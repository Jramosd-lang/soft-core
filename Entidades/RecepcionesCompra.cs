using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades
{
    [Table("recepciones_compra")]
    public class RecepcionCompra
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("numero_lote")]
        public int NumeroLote { get; set; }

        [Column("cantidad_recibida")]
        public int CantidadRecibida { get; set; }

        [Column("costo_promedio_unitario", TypeName = "numeric(10,2)")]
        public decimal? CostoPromedioUnitario { get; set; }

        [Column("fecha_recepcion")]
        public DateTime FechaRecepcion { get; set; }

        [Column("observaciones")]
        public string? Observaciones { get; set; }

        [Column("item_orden_compra_id")]
        public int ItemOrdenCompraId { get; set; }

        [Column("usuario_id")]
        public int UsuarioId { get; set; }

        // 🔥 Navegación

        public ItemOrdenCompra ItemOrdenCompra { get; set; } = null!;

        public Usuario Usuario { get; set; } = null!;
    }
}