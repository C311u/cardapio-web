using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CardapioWeb.Models
{
    [Table("Produtos")]
    public class Produto
    {
        [Key] //identifica como chave primaria
        public int Id { get; set; }

        [Display(Name ="Nome do produto")] //dar nome ao campo
        [Required(ErrorMessage ="Campo obrigatório")] //faz com que o campo seja de preenchimento obrigatório
        [MinLength(5, ErrorMessage ="O nome do produto deve ter no mínimo {0} caracteres")] //define quantidade mínima de caracteres
        public string Nome { get; set; }

        [Display(Name = "Descrição curta do produto")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Descricao_Curta { get; set; }

        [Display(Name = "Descrição detalhada do produto")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Descricao_Detalhada { get; set; }

        [Display(Name = "Preço do produto")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public decimal Preco { get; set; }
        public string Local_Imagem { get; set; }
        public bool Produto_Preferido { get; set; }
        public bool Em_Estoque { get; set; }

        public virtual Categoria Categoria { get; set; } //gera chave estrangeira, produto deriva de categoria
    }
}
