using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades
{
    [Table("categorias_productos")]
    public class CategoriaProducto
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        [Column("nombre")]
        public string Nombre { get; set; } = string.Empty;

        [MaxLength(100)]
        [Column("descripcion")]
        public string? Descripcion { get; set; }
    }
}