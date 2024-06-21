using CardapioWeb.Models;

namespace CardapioWeb.Repositories
{
    public interface IProdutoRepository
    {
        IEnumerable<Produto> GetAll(); //método que retorna/busca todos os itens da listas
        IEnumerable<Produto> GetByPreferidos(); //Cria uma lista de produtos pela definição preferidos 
        Produto GetById(int id); //buscar um registro específico do registro através do ID
    }
}
// define o que o Produto deve ter de métodos 