using ColitexDDD.Dominio.Entidades;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Colitex.Persistencia.Contexto
{
    public class ColitexDDDContexto : DbContext
    {
        public ColitexDDDContexto()
            :base ("ColitexDDD")
        {

        }

        public DbSet <Funcionario> Funcionarios { get; set; }
        public DbSet <Produtores> Produtores{ get; set; }
        public DbSet <Administrador> Administrador { get; set; }
        public DbSet <Produtos> Produtos{ get; set; }
        public DbSet <CategoriaProduto> CategoriaProduto { get; set; }
        public DbSet <Compra> Compra { get; set; }
    }

}
