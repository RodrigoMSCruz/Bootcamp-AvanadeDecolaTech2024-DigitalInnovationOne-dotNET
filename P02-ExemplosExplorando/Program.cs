using P02_ExemplosExplorando.Models;
using System.Data;
using System.Globalization;

//CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");

/*
Pessoa p1 = new Pessoa();
p1.Nome = "Buta";
p1.Idade = 20;
p1.Apresentar();
*/

Pessoa p1 = new Pessoa("Leonardo","Buta");
Pessoa p2 = new Pessoa(nome: "Eduardo", sobrenome: "Neves Queiroz");

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();

decimal valorMonetario = 1582.40M;

Console.WriteLine($"{valorMonetario:C}"); // Pega a configuração default do sistema
Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US"))); //Força uma cultura específica

DateTime data = DateTime.Now;
Console.WriteLine(data.ToString("dd/MM/YYYY HH:mm"));

DateTime hora = DateTime.Parse("12/04/2022 18:00");
Console.WriteLine(hora);

string datastring = "2022-12-17 18:00";
DateTime hora2 = DateTime.Parse(datastring);
Console.WriteLine(hora2);

bool sucesso = DateTime.TryParseExact(datastring,
                        "yyy-MM-dd HH:mm",
                        CultureInfo.InvariantCulture,
                        DateTimeStyles.None,
                        out hora2
                        );
if (sucesso){
    Console.WriteLine($"Conversão com sucesso! Data: {hora2}");
}
else
{
    Console.WriteLine($"Conversão de data falhou! Data: {datastring}");
}
Console.WriteLine(hora2);