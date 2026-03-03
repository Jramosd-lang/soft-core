using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades
{
    [Table("ordenes_trabajo")]
    public class OrdenTrabajo
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        [Column("numero")]
        public string Numero { get; set; } = string.Empty;

        [Required]
        [MaxLength(30)]
        [Column("estado")]
        public string Estado { get; set; } = string.Empty;

        [Required]
        [MaxLength(20)]
        [Column("prioridad")]
        public string Prioridad { get; set; } = string.Empty;

        [Column("descripcion")]
        public string? Descripcion { get; set; }

        [Column("fecha_creacion")]
        public DateTime FechaCreacion { get; set; }

        [Column("fecha_compromiso_entrega")]
        public DateTime? FechaCompromisoEntrega { get; set; }

        [Column("fecha_entrega")]
        public DateTime? FechaEntrega { get; set; }

        [MaxLength(20)]
        [Column("metodo_pago")]
        public string? MetodoPago { get; set; }

        [Column("subtotal_monto", TypeName = "numeric(12,2)")]
        public decimal? SubtotalMonto { get; set; }

        [Column("descuento_monto", TypeName = "numeric(12,2)")]
        public decimal? DescuentoMonto { get; set; }

        [Column("anticipo_pagado", TypeName = "numeric(12,2)")]
        public decimal? AnticipoPagado { get; set; }

        [Column("total_monto", TypeName = "numeric(12,2)")]
        public decimal? TotalMonto { get; set; }

        [Column("cliente_id")]
        public int ClienteId { get; set; }

        [Column("usuario_id")]
        public int UsuarioId { get; set; }

        // 🔥 Navegación

        public Cliente Cliente { get; set; } = null!;

        public Usuario Usuario { get; set; } = null!;

        public ICollection<ItemOrdenTrabajo> ItemsOrdenTrabajo { get; set; }
            = new List<ItemOrdenTrabajo>();
    }
}