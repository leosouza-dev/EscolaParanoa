using EscolaParanoa.Alunos;
using EscolaParanoa.Externos;
using EscolaParanoa.Funcionarios;
using EscolaParanoa.SistemaEscolar;

Console.WriteLine("Bem-Vindos a Escola Paranoá!!!");

// criando Escola Paranoá
var escolaParanoa = new Escola("Paranoá", "Av. Casa Grande, 1731");

// criando Professor
Console.WriteLine("");
Console.WriteLine("------------------------------------------------------------------------");
var professor = new Professor("Leonardo", 123, escolaParanoa);
Console.WriteLine("Professor: " + professor.Nome);
Console.WriteLine("RE: " + professor.RE);
Console.WriteLine("Escola: " + professor.Escola.Nome);

// criando Diretor
Console.WriteLine("");
Console.WriteLine("------------------------------------------------------------------------");
var diretor = new Diretor("Carlos", 111, escolaParanoa);
Console.WriteLine("Professor: " + diretor.Nome);
Console.WriteLine("RE: " + diretor.RE);
Console.WriteLine("Escola: " + diretor.Escola.Nome);

// aluno Primario
Console.WriteLine("");
Console.WriteLine("------------------------------------------------------------------------");
try
{
    var alunoPrimario = new EstudantePrimario("Julia", 8);
    alunoPrimario.Nota = 7;
    Console.WriteLine("Aluno Primário: " + alunoPrimario.Nome);
    Console.WriteLine("Idade: " + alunoPrimario.Idade);
    Console.WriteLine("Nota: " + alunoPrimario.Nota);
    Console.WriteLine("O Aluno Primário passou de ano? - " + alunoPrimario.PassouDeAno());

}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

// aluno Ensino Medio
Console.WriteLine("");
Console.WriteLine("------------------------------------------------------------------------");
var alunoEnsinoMedio = new EstudanteEnsinoMedio("Pedro", 16);
alunoEnsinoMedio.Nota = 7;
Console.WriteLine("Aluno Ensino Medio: " + alunoEnsinoMedio.Nome);
Console.WriteLine("Idade: " + alunoEnsinoMedio.Idade);
Console.WriteLine("Nota: " + alunoEnsinoMedio.Nota);
Console.WriteLine("O Aluno do ensino médio passou de ano? - " + alunoEnsinoMedio.PassouDeAno());

// MEC
Console.WriteLine("");
Console.WriteLine("------------------------------------------------------------------------");
var mec = new MEC("Ministério da Educação");
Console.WriteLine("Orgão Externo à Escola: " + mec.Nome);

// Relatório Total de Alunos
Console.WriteLine("");
Console.WriteLine("------------------------------------------------------------------------");
Console.WriteLine("MEC - O total de alunos é: " + mec.GetTotalEstudantes());
Console.WriteLine("Diretor - O total de alunos é: " + diretor.GetTotalEstudantes());
//Console.WriteLine("O total de alunos é: " + professor.GetTotalEstudantes());

Console.WriteLine("");
Console.WriteLine("------------------------------------------------------------------------");
Console.WriteLine("Pressione uma Tecla para Terminar o sistema!");
Console.ReadKey();