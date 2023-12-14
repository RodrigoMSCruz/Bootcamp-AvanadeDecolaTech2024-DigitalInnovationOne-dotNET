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
Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));

DateTime hora = DateTime.Parse("12/04/2022 18:00");
Console.WriteLine(hora);

string datastring = "2022-12-17 18:00";
DateTime hora2 = DateTime.Parse(datastring);
Console.WriteLine(hora2);

bool sucesso = DateTime.TryParseExact(datastring,
                        "yyyy-MM-dd HH:mm",
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

Console.WriteLine("");
//Exceções

try
{
    //string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");
    string[] linhas = File.ReadAllLines("Arquivos/arquivo_Leitura.txt"); //Arquivo escrito errado propositalemnte para provocar uma exceção

    foreach (string linha in linhas)
    {
        Console.WriteLine(linha);
    }

}

catch(FileNotFoundException ex)
{
   Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado. {ex.Message}");
}

catch(DirectoryNotFoundException ex)
{
    Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Caminho da pasta não encontrada. {ex.Message}");
}

catch(Exception ex)
{
    Console.WriteLine($"Ocorreu uma exceção genérica.{ex.Message}");
}

finally
{
    Console.WriteLine("Arquivo OK!");
}

Console.WriteLine("");
//Usando Throw

new ExemploExcecao().Metodo1();

Console.WriteLine("");
//Usando Pilha(Stack)

Stack<int> pilha = new Stack<int>();

pilha.Push(4);
pilha.Push(6);
pilha.Push(8);
pilha.Push(10);

foreach(int item in pilha)
{
    Console.WriteLine(item);
}

Console.WriteLine($"Removendo um item da pilha:  {pilha.Pop()}");

pilha.Push(20);

foreach(int item in pilha)
{
    Console.WriteLine(item);
}

Console.WriteLine("");
//Usando Dictionary

Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("SP", "São Paulo");
estados.Add("BA", "Bahia");
estados.Add("MG", "Minas Gerais");

foreach(var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

estados.Remove("BA");
Console.WriteLine("---");

foreach(var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

estados["SP"] = "São Paulo - valor alterado";
Console.WriteLine("---");

foreach(var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}