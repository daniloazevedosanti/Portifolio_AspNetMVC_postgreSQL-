using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication3.Models
{
    [Table("membros", Schema = "public")]
    public class Membro
    {
        [Key]
        [Column("idprojeto")]
        public int IdProjeto { get; set; }

        [Column("idpessoa")]
        public int IdPessoa { get; set; }

        [ForeignKey("IdProjeto")]
        public Projeto Projeto { get; set; }
        
        [ForeignKey("IdPessoa")]
        public Pessoa Pessoa { get; set; }
    }
}