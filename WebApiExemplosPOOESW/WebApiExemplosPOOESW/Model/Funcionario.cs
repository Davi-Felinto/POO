namespace WebApiExemplosPOOESW.Model
{
    public class Funcionario
    {
        private int id;
        private string nome;
        private string cpf;
        private string email;
        private string cargo;
        private double salario;
        private DateTime sataAdimissao;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Email { get => email; set => email = value; }
        public string Cargo { get => cargo; set => cargo = value; }
        public double Salario { get => salario; set => salario = value; }
        public DateTime SataAdimissao { get => sataAdimissao; set => sataAdimissao = value; }

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
