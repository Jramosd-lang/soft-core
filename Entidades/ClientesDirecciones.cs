using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades
{
    [Table("clientes_direcciones")]
    public class ClienteDireccion
    {
        [Column("cliente_id")]
        public int ClienteId { get; set; }

        [Column("direccion_id")]
        public int DireccionId { get; set; }

        [Column("es_principal")]
        public bool EsPrincipal { get; set; }

        // 🔥 Navegación
        public Cliente Cliente { get; set; } = null!;
        public Direccion Direccion { get; set; } = null!;
    }
}