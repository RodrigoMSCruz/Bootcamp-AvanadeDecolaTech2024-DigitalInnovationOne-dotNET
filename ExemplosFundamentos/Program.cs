using ExemploFundamentos.Models;

// Orientação a objetos

Pessoa p = new Pessoa();

p.Nome = "Buta";
p.Idade = 26;
p.Apresentar();

//Formatando variável de DateTime

DateTime dataAtual = DateTime.Now.AddDays(5); //O parâmetro 5 informa que a data será 5 dias a mais da data atual
Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));

//Converter tipo de variáveis

int a = Convert.ToInt32("5"); //Convert aceita normalmente valores nulos. "Null".
// int a = int.Parse("5"); // Não aceita valores nulos "Null".
Console.WriteLine(a);

int inteiro = 5;
string texto = inteiro.ToString();
Console.WriteLine(texto);

// Conversão implícita

int b = 5;
double d = b;
Console.WriteLine(d);

// Conversão segura

string texto2 = "15-b";
int e = 0;

int.TryParse(texto2, out e);

Console.WriteLine(e);

// Conversão segura 2

string texto3 = "15-b";

int.TryParse(texto3, out int f);

Console.WriteLine(f);

int quantidadeEmEstoque = 30;
int quantidadeCompra = 4;

if (quantidadeEmEstoque >= quantidadeCompra){
    Console.WriteLine("Venda realizada.");
}
else{
    Console.WriteLine("Quantidade insuficiente em estoque.");
}

Console.WriteLine("Digite uma letra: ");
string? letra = Console.ReadLine();

/*
if (letra == "a" || letra == "e" || letra == "i" || letra == "o" || letra == "u"){
    Console.WriteLine("É vogal");
}
else{
    Console.WriteLine("Não é vogal");
}
*/

switch (letra){
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        Console.WriteLine("É vogal");
        break;
    default:
        Console.WriteLine("Não é vogal");
        break;
}