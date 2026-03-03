using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades
{
    [Table("direcciones")]
    public class Direccion
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [MaxLength(40)]
        [Column("linea_1")]
        public string Linea1 { get; set; } = string.Empty;

        [MaxLength(40)]
        [Column("linea_2")]
        public string? Linea2 { get; set; }

        [MaxLength(40)]
        [Column("barrio")]
        public string? Barrio { get; set; }

        [MaxLength(200)]
        [Column("indicaciones")]
        public string? Indicaciones { get; set; }

        [Column("ciudad_id")]
        public int CiudadId { get; set; }

        // 🔥 Navegación

        public Ciudad Ciudad { get; set; } = null!;

        public ICollection<ClienteDireccion> ClientesDirecciones { get; set; }
            = new List<ClienteDireccion>();

        public ICollection<ProveedorDireccion> ProveedoresDirecciones { get; set; }
            = new List<ProveedorDireccion>();

        public ICollection<Ubicacion> Ubicaciones { get; set; }
            = new List<Ubicacion>();
    }
}