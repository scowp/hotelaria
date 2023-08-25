using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Model
{
    [Table("TB_PAGAMENTO")]
    public class Pagamento
    {
        [Key]
        public int PagamentoId { get; set; }
        [ForeignKey("TipoQuarto")]
        public int ReservaId { get; set; }
        [Required]
        public DateTime DataPagamento { get; set; }
        [Required]
        public float Total { get; set; }

        public virtual ICollection<Reserva> reserva { get; set; }
    }
}
