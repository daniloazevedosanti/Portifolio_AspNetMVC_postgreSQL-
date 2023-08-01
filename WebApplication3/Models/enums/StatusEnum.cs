using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace WebApplication3.Models.enums
{
    public enum StatusEnum
    {
        [Description("em análise")]
        em_analise,

        [Description("análise realizada")]
        analise_realizada,

        [Description("análise aprovada")]
        analise_aprovada,

        [Description("iniciado")]
        iniciado,

        [Description("planejado")]
        planejado,

        [Description("em andamento")]
        em_andamento,

        [Description("encerrado")]
        encerrado,

        [Description("cancelado")]
        cancelado,
    }
}