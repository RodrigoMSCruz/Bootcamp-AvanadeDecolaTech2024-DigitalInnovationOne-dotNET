using System.ComponentModel;
using ExemplosFundamentos.Models;

// Orientação a objetos

Pessoa p = new Pessoa();

p.Nome = "Buta";
p.Idade = 26;
p.Apresentar();

//Formatando variável de DateTime

DateTime dataAtual = DateTime.Now.AddDays(5); //O parâmetro 5 informa que a data será 5 dias a mais da data atual
Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));

Console.WriteLine("");

//Converter tipo de variáveis

int a = Convert.ToInt32("5"); //Convert aceita normalmente valores nulos. "Null".
// int a = int.Parse("5"); // Não aceita valores nulos "Null".
Console.WriteLine(a);

Console.WriteLine("");

int inteiro = 5;
string texto = inteiro.ToString();
Console.WriteLine(texto);

Console.WriteLine("");

// Conversão implícita

int b = 5;
double c = b;
Console.WriteLine(c);

Console.WriteLine("");

// Conversão segura

string texto2 = "15-b";
int d = 0;

int.TryParse(texto2, out d);

Console.WriteLine(d);

Console.WriteLine("");

// Conversão segura 2

string texto3 = "15-b";

int.TryParse(texto3, out int e);

Console.WriteLine(e);


Console.WriteLine("");

// Condicionais "if"

int quantidadeEmEstoque = 30;
int quantidadeCompra = 4;

if (quantidadeEmEstoque >= quantidadeCompra){
    Console.WriteLine("Venda realizada.");
}
else{
    Console.WriteLine("Quantidade insuficiente em estoque.");
}

Console.WriteLine("");
// Usando "CASE" em vez de "IF"


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

//Operadores Aritmétricos
Console.WriteLine("");

Calculadora calc = new Calculadora();

calc.Somar(10, 30);
calc.Subtrair(10, 50);
calc.Multiplicar(15, 45);
calc.Dividir(2, 2);
calc.Potencia(3, 3);
calc.Seno(30);
calc.Coseno(30);
calc.Tangente(30);
calc.RaizQuadrada(9);

// Estruturas de repetição
// FOR

Console.WriteLine("");

int m = 5;
for(int contador =0; contador <=10; contador++){
    Console.WriteLine($"{m} x {contador} = {m * contador}");
}

// Estruturas de repetição
// WHILE
Console.WriteLine("");

m = 5;
int cont = 1;
while (cont <= 10){
    Console.WriteLine($"{m} x {cont} = {m * cont}");
    cont++;
    
    if (cont == 6){
        break;
    }
}

// Estruturas de repetição
// DO-WHILE
Console.WriteLine("");

int soma = 0;
int numeroDigitado = 0;

do{
    Console.WriteLine("Digite um número (0 para parar): ");
    numeroDigitado = Convert.ToInt32(Console.ReadLine());

    soma += numeroDigitado;

} while(numeroDigitado != 0);

Console.WriteLine($"Total da soma dos números digitados é: {soma}");

// Array
Console.WriteLine("");

int[] arrayInteiros = new int[3];

arrayInteiros[0] = 72;
arrayInteiros[1] = 64;
arrayInteiros[2] = 50;

for(int ind = 0; ind < arrayInteiros.Length; ind++){
    Console.WriteLine($"Posição Nº {ind} - {arrayInteiros[ind]}");
}

foreach(int valor in arrayInteiros){
    Console.WriteLine(valor);
}

// Listas
Console.WriteLine("");

List<string> listaString = new List<string>();

listaString.Add("SP");
listaString.Add("BA");
listaString.Add("MG");

for(int contador = 0; contador < listaString.Count; contador++){
    Console.WriteLine($"Posição Nº {contador} - {listaString[contador]}");
}

foreach(string item in listaString){
    Console.WriteLine($"{item}");
}