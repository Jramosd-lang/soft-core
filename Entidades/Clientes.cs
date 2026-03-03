using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades
{
    [Table("clientes")]
    public class Cliente
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("tipo_cliente")]
        public string TipoCliente { get; set; } = string.Empty;

        [Required]
        [Column("primer_nombre")]
        public string PrimerNombre { get; set; } = string.Empty;

        [Column("segundo_nombre")]
        public string? SegundoNombre { get; set; }

        [Required]
        [Column("primer_apellido")]
        public string PrimerApellido { get; set; } = string.Empty;

        [Column("segundo_apellido")]
        public string? SegundoApellido { get; set; }

        [Column("costo_unitario")]
        public decimal CostoUnitario { get; set; }

        [Column("tipo_referencia")]
        public string? TipoReferencia { get; set; }

        [Column("notas")]
        public string? Notas { get; set; }

        [Column("nombre_comercial")]
        public string? NombreComercial { get; set; }

        [Column("identificacion_fiscal")]
        public string? IdentificacionFiscal { get; set; }

        [Column("tipo_identificacion")]
        public string? TipoIdentificacion { get; set; }

        [Column("numero_identificacion")]
        public string? NumeroIdentificacion { get; set; }

        [Required]
        [Column("correo")]
        public string Correo { get; set; } = string.Empty;

        [Required]
        [Column("telefono")]
        public string Telefono { get; set; } = string.Empty;

        [Column("notas_internas")]
        public string? NotasInternas { get; set; }

        [Column("descuento_porcentaje")]
        public decimal? DescuentoPorcentaje { get; set; }

        [Required]
        [Column("estado")]
        public string Estado { get; set; } = string.Empty;

        [Column("fecha_afiliacion")]
        public DateTime FechaAfiliacion { get; set; }

        // 🔥 Relaciones

        public ICollection<OrdenTrabajo> OrdenesTrabajo { get; set; }
            = new List<OrdenTrabajo>();

        public ICollection<ClienteDireccion> ClientesDirecciones { get; set; }
            = new List<ClienteDireccion>();
    }
}