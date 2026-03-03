using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades
{
    [Table("productos")]
    public class Producto
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [MaxLength(20)]
        [Column("codigo_sku")]
        public string? CodigoSku { get; set; }

        [MaxLength(500)]
        [Column("url_imagen")]
        public string? UrlImagen { get; set; }

        [Required]
        [MaxLength(40)]
        [Column("nombre")]
        public string Nombre { get; set; } = string.Empty;

        [Column("descripcion")]
        public string? Descripcion { get; set; }

        [Required]
        [MaxLength(20)]
        [Column("unidad_medida")]
        public string UnidadMedida { get; set; } = string.Empty;

        [Column("precio_base", TypeName = "numeric(12,2)")]
        public decimal PrecioBase { get; set; }

        [Column("costo_estimado", TypeName = "numeric(12,2)")]
        public decimal CostoEstimado { get; set; }

        [Column("requiere_inventario")]
        public bool RequiereInventario { get; set; }

        [Required]
        [MaxLength(20)]
        [Column("estado")]
        public string Estado { get; set; } = string.Empty;

        [Column("punto_reordenar", TypeName = "numeric(12,2)")]
        public decimal PuntoReordenar { get; set; }

        [Column("cantidad_reordenar", TypeName = "numeric(12,2)")]
        public decimal? CantidadReordenar { get; set; }

        [Column("fecha_adicion")]
        public DateTime FechaAdicion { get; set; }

        [Column("fecha_eliminacion")]
        public DateTime? FechaEliminacion { get; set; }

        [Column("categoria_id")]
        public int CategoriaId { get; set; }

        // 🔥 Navegación

        public CategoriaProducto Categoria { get; set; } = null!;

        public ICollection<VarianteProducto> Variantes { get; set; }
            = new List<VarianteProducto>();
    }
}