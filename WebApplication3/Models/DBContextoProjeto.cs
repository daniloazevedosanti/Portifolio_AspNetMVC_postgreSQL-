using System.Data.Entity;

namespace WebApplication3.Models
{
    public class DBContextoProjeto : DbContext
    {
        public DbSet<Projeto> ProjetosObj { get; set; }
        public DBContextoProjeto() : base("conexao")
        {
        }
        

        //public virtual DbSet<Membro> MembrosObj { get; set; }


    }
}