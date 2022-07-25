namespace EscolaParanoa.Alunos
{
    public class EstudanteEnsinoMedio : Estudante
    {
        public EstudanteEnsinoMedio(string nome, int idade) : base(nome, idade)
        {
        }

        public override bool PassouDeAno()
        {
            return Nota > 8.0;
        }
    }
}
