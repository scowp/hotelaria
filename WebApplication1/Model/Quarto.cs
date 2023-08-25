using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Model
{
    [Table("TB_QUARTO")]
    public class Quarto
    {
        [Key]
        public int QuartoId { get; set; }
        [Required]
        public String NumeroQuarto { get; set; }
        [Required]
        public float PrecoPorNoite { get; set; }
        [ForeignKey("TipoQuarto")]
        public int TipoQuartoId { get; set; }
        public virtual ICollection<TipoQuarto> tipoQuarto { get; set; }


    }
}
