using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Model
{
    [Table("TB_TP_QUARTO")]
    public class TipoQuarto
    {
        [Key]
        public int TipoQuartoId { get; set; }
        [Required]
        public String Descricao { get; set; }

        public virtual ICollection<Quarto> Quarto { get; set; }
    }
}
