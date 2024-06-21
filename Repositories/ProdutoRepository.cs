using CardapioWeb.Context;
using CardapioWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace CardapioWeb.Repositories
{
    public class ProdutoRepository : IProdutoRepository //herdando características do IProdutoRepository
    {
        private readonly AppDBContext _dbContext; //classe responsável por manipular a conexão com o BD

        public ProdutoRepository(AppDBContext dbContext) //criando a utilização para conexão com o BD
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Produto> GetAll()
        {
            return _dbContext.Produtos.ToList(); //busca tudo que há na tabela produtos, ToList converte em uma lista
        }

        public Produto GetById(int id)
        {
            return _dbContext.Produtos.FirstOrDefault(p => p.Id == id); //busca pela referencia ID, o FirstOrDefault peg o primeiro encontrado, se não achar envia uma mensgame de erro
        }

        public IEnumerable<Produto> GetByPreferidos()
        {
            return _dbContext.Produtos.Where(p => p.Produto_Preferido).ToList(); //busca pela referência dos produtos preferidos e monta uma lista
        }
    }
}