using System.Data.Entity;

namespace WebApplication3.Models
{
    public class DBContexto : DbContext
    {
        public DbSet<Pessoa> PessoasObj { get; set; }
        public DbSet<Projeto> ProjetosObj { get; set; }
        public DbSet<Membro> MembrosObj { get; set; }
        public DBContexto() : base("conexao")
        {
            // the terrible hack
            //var ensureDLLIsCopied = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }

        


    }
}