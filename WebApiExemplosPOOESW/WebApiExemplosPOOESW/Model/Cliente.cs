namespace WebApiExemplosPOOESW.Model
{
    public class Cliente
    {
        private int id;
        private string nome;
        private string cpfCnpj;
        private string email;
        private string telefone;
        private string endereco;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string CpfCnpj { get => cpfCnpj; set => cpfCnpj = value; }
        public string Email { get => email; set => email = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Endereco { get => endereco; set => endereco = value; }

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

        public string ListaTodos()
        {
            // Pesquisar todos no banco dedos
            return "";
        }

        public string PesquisarPorNome(string nome)
        {
            // Pesquisar no banco de dados por nome
            return "";
        }
    }
}
