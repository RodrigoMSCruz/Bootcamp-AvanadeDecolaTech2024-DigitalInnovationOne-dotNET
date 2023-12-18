using P03_ExemploPOO.Models;

Pessoa p1 = new Pessoa("Leonardo");
p1.Idade = 20;
p1.Apresentar();

//ContaCorrente c1 = new ContaCorrente(123, 1000);
//c1.ExibirSaldo();
//c1.Sacar(500);
//c1.ExibirSaldo();

//Herança e Polimorfisomo
Console.WriteLine("");

Aluno a1 = new Aluno("Leonardo");
a1.Idade = 20;
a1.Nota = 9.2;
a1.Apresentar();

Professor pr1 = new Professor();
pr1.Nome = "Eduardo";
pr1.Idade = 30;
pr1.Apresentar();

Corrente c = new Corrente();
c.Creditar(500);
c.ExibirSaldo();