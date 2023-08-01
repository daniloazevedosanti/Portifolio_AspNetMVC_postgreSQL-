using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplication3.Models.enums;

namespace WebApplication3.Models
{
    [Table("projeto", Schema = "public")]
    public class Projeto
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        [Column("nome")]
        public string Nome { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "Data Inicio")]
        [Column("data_inicio")]
        public DateTime DataInicio { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "Data Previsão Fim")]
        [Column("data_previsao_fim")]
        public DateTime DataPrevisaoFim { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "Data Fim")]
        [Column("data_fim")]
        public DateTime DataFim { get; set; }

        [Display(Name = "Descrição")]
        [Column("descricao")]
        public string Descricao { get; set; }

        [Display(Name = "Status")]
        [Column("status")]
        public string Status { get; set; }

        [Display(Name = "Orçamento Total")]
        [Column("orcamento")]
        public double Orcamento { get; set; }

        [Display(Name = "Risco")]
        [Column("risco")]
        public string Risco { get; set; }

        [Display(Name = "Gerente Responsável")]
        [Column("idgerente")]
        public int IdGerente { get; set; }

        [Display(Name = "Gerente Responsável")]
        [ForeignKey("IdGerente")]
        public Pessoa Gerente { get; set; }

    }
}