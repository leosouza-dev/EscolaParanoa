namespace EscolaParanoa.SistemaEscolar
{
    public class Escola
    {
        public Escola(string nome, string enddereco)
        {
            Nome = nome;
            Enddereco = enddereco;
        }

        public string Nome { get; private set; }
        public string Enddereco { get; private set; }
    }
}
