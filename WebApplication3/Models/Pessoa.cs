using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    [Table("pessoa", Schema = "public")]
    public class Pessoa
    {

        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        [Column("nome")]
        public string Nome { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "Data de Nascimento")]
        [Column("datanascimento")]
        public DateTime DataNascimento { get; set; }

        [Display(Name = "CPF")]
        [Column("cpf")]
        public string Cpf { get; set; }

        [Display(Name = "Funcionário")]
        [Column("funcionario")]
        public bool Funcionario { get; set; }

    }
}