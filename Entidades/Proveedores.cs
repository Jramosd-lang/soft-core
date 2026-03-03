using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades
{
    [Table("proveedores")]
    public class Proveedor
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        [Column("codigo")]
        public string Codigo { get; set; } = string.Empty;

        [Required]
        [MaxLength(20)]
        [Column("primer_nombre")]
        public string PrimerNombre { get; set; } = string.Empty;

        [MaxLength(20)]
        [Column("segundo_nombre")]
        public string? SegundoNombre { get; set; }

        [Required]
        [MaxLength(20)]
        [Column("primer_apellido")]
        public string PrimerApellido { get; set; } = string.Empty;

        [MaxLength(20)]
        [Column("segundo_apellido")]
        public string? SegundoApellido { get; set; }

        [MaxLength(40)]
        [Column("nombre_comercial")]
        public string? NombreComercial { get; set; }

        [MaxLength(30)]
        [Column("razon_social")]
        public string? RazonSocial { get; set; }

        [MaxLength(15)]
        [Column("identificacion_fiscal")]
        public string? IdentificacionFiscal { get; set; }

        [MaxLength(20)]
        [Column("tipo_identificacion")]
        public string? TipoIdentificacion { get; set; }

        [MaxLength(20)]
        [Column("numero_identificacion")]
        public string? NumeroIdentificacion { get; set; }

        [Required]
        [MaxLength(254)]
        [Column("correo")]
        public string Correo { get; set; } = string.Empty;

        [Required]
        [MaxLength(15)]
        [Column("telefono")]
        public string Telefono { get; set; } = string.Empty;

        [MaxLength(70)]
        [Column("sitio_web")]
        public string? SitioWeb { get; set; }

        [Column("notas")]
        public string? Notas { get; set; }

        [MaxLength(20)]
        [Column("calificacion")]
        public string? Calificacion { get; set; }

        [Required]
        [MaxLength(20)]
        [Column("estado")]
        public string Estado { get; set; } = string.Empty;

        [Column("fecha_registro")]
        public DateTime FechaRegistro { get; set; }

        // 🔥 Navegación

        public ICollection<OrdenCompra> OrdenesCompra { get; set; }
            = new List<OrdenCompra>();

        public ICollection<ProveedorDireccion> ProveedoresDirecciones { get; set; }
            = new List<ProveedorDireccion>();
    }
}