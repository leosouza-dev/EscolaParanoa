namespace EscolaParanoa.Alunos
{
    public abstract class Estudante
    {
        public static int _totalDeEstudantes;
        protected Estudante(string nome, int idade)
        {
            if(nome == "")
            {
                throw new ArgumentException("Nome precisa ser preechido");
            }

            if (idade < 0)
            {
                throw new ArgumentException("Idade precisa ser maior que 0");
            }

            Nome = nome;
            Idade = idade;

            _totalDeEstudantes++;
        }

        public string Nome { get; }
        public int Idade { get; }
        public double Nota { get; set; }

        public abstract bool PassouDeAno();
    }
}
