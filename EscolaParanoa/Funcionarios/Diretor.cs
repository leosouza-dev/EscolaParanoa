using EscolaParanoa.Alunos;
using EscolaParanoa.Interfacces;
using EscolaParanoa.SistemaEscolar;

namespace EscolaParanoa.Funcionarios
{
    public class Diretor : Funcionario, IGeraRelatorioTotalDeAlunos
    {
        public Diretor(string nome, int re, Escola escola) : base(nome, re, escola)
        {
        }

        public int GetTotalEstudantes()
        {
            return Estudante._totalDeEstudantes;
        }
    }
}
