using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P03_ExemploPOO.Models
{
    public class Aluno : Pessoa
    {
        public double Nota { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Meu nome é {Nome}, tenho {Idade}, anos e tenho nota {Nota}.");
        }
    }
}