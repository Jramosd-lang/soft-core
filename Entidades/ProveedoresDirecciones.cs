using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades
{
    [Table("proveedores_direcciones")]
    public class ProveedorDireccion
    {
        [Column("proveedor_id")]
        public int ProveedorId { get; set; }

        [Column("direccion_id")]
        public int DireccionId { get; set; }

        [Column("es_principal")]
        public bool EsPrincipal { get; set; }

        // 🔥 Navegación

        public Proveedor Proveedor { get; set; } = null!;

        public Direccion Direccion { get; set; } = null!;
    }
}