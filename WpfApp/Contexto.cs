using System.Data.Entity;
using WpfApp.model;

namespace WpfApp
{
    public class Categoria : DbContext
    {
        public Categoria(): base(nameOrConnectionString : "conexao")
        {
            Database.SetInitializer<Categoria>(new CategoriaApp());
        }
        public DbSet<Produto> Produtos { get; set; }
    }
    public class CategoriaApp : DropCreateDatabaseAlways<Categoria>
    {

    }
}
