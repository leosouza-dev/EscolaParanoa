using EscolaParanoa.SistemaEscolar;

namespace EscolaParanoa.Funcionarios
{
    public class Funcionario
    {
        public Funcionario(string nome, int re, Escola escola)
        {
            Nome = nome;
            RE = re;
            Escola = escola;
        }

        public string Nome { get; private set; }
        public int RE { get; private set; }
        public Escola Escola { get; private set; }
    }
}
