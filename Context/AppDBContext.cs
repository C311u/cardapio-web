using CardapioWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace CardapioWeb.Context
{
    public class AppDBContext: DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options): base(options) { } //fazer a comunicação com o Banco

        public DbSet<Categoria> Categorias { get; set; } //Validar a conexão da classe com a tabela
        public DbSet<Produto> Produtos { get; set; } //Validar a conexão da classe com a tabela
    }
}
//arquivo por manter a comunicação com o BD
