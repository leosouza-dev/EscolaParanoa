using EscolaParanoa.Alunos;
using EscolaParanoa.Interfacces;

namespace EscolaParanoa.Externos
{
    public class MEC : IGeraRelatorioTotalDeAlunos
    {
        public MEC(string nome)
        {
            Nome = nome;
        }

        public string Nome { get; private set; }

        public int GetTotalEstudantes()
        {
            return Estudante._totalDeEstudantes;
        }
    }
}
