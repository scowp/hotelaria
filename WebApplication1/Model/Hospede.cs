using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Model
{
    [Table("TB_HOSPEDE")]
    public class Hospede
    {
        [Key]
        public int HospedeId { get; set; }
        [Required]
        public String Nome { get; set; }
        [Required]
        public String Sobrenome { get; set; }
        [Required]
        public String Email { get; set; }
        [Required]
        public String Telefone { get; set; }


    }
}
