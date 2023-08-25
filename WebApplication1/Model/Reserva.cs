using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net;

namespace WebApplication1.Model
{
    [Table("TB_RESERVA")]
    public class Reserva
    {
        [Key]
        public int ReservaId { get; set; }
        [ForeignKey("Hospede")]
        public int HospedeId { get; set; }
        [ForeignKey("Quarto")]
        public int QuartoId { get; set; }
        [ForeignKey("Pagamento")]
        public int PagamentoId { get; set; }
        [Required]
        public DateTime DataEntrada { get; set; }
        [Required]
        public DateTime DataSaida { get; set; }
        [Required]
        public float ValorTotal { get; set; }
        public virtual Hospede hospede { get; set; }

    }
}
