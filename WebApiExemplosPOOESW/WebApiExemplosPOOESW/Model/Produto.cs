using System.Reflection.Metadata;

namespace WebApiExemplosPOOESW.Model
{
    public class Produto
    {
        private int id;
        private string nome;
        private string descricao;
        private int quantidadeEstoque;
        private double inidadeMedida;
        private double precoUnitario;
        private Blob imgProduto;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public int QuantidadeEstoque { get => quantidadeEstoque; set => quantidadeEstoque = value; }
        public double InidadeMedida { get => inidadeMedida; set => inidadeMedida = value; }
        public double PrecoUnitario { get => precoUnitario; set => precoUnitario = value; }
        public Blob ImgProduto { get => imgProduto; set => imgProduto = value; }

        public void Adicionar()
        {
            // Adiciona no Banco de dados
        }

        public void Excluir(int id)
        {
            // Excluir no banco dedos
        }

        public void Alterar(int id)
        {
            // Alterar no banco de dados
        }

        public string PesquisarPorId(int id)
        {
            // Pesquisar no banco de dados por id
            return "";
        }

        public string ListaTodosProdutos()
        {
            // Pesquisar todos no banco dedos
            return "";
        }
}
