using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace WebApplication3.Models.enums
{
    public enum RiscoEnum
    {
        [Description("Alto risco")]
        alto_risco,

        [Description("Médio risco")]
        medio_risco,

        [Description("Baixo risco")]
        baixo_risco,
    }
}