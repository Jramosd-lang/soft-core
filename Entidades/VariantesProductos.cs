using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades
{
    [Table("variantes_productos")]
    public class VarianteProducto
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [MaxLength(500)]
        [Column("url_imagen")]
        public string? UrlImagen { get; set; }

        [Required]
        [MaxLength(40)]
        [Column("nombre")]
        public string Nombre { get; set; } = string.Empty;

        [Column("ajuste_precio", TypeName = "numeric(12,2)")]
        public decimal AjustePrecio { get; set; }

        [Required]
        [MaxLength(20)]
        [Column("estado")]
        public string Estado { get; set; } = string.Empty;

        [Column("producto_id")]
        public int ProductoId { get; set; }

        // 🔥 Navegación

        public Producto Producto { get; set; } = null!;

        public ICollection<ItemOrdenCompra> ItemsOrdenCompra { get; set; }
            = new List<ItemOrdenCompra>();

        public ICollection<ExistenciaInventario> ExistenciasInventario { get; set; }
            = new List<ExistenciaInventario>();
    }
}