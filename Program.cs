using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConvertendoValores
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int idade;
            char sexo;
            double salario;

            Console.Write("Informe o seu nome: ");
            nome = Console.ReadLine();

            Console.Write("Informe a sua idade: ");
            idade = Convert.ToInt16(Console.ReadLine());

            Console.Write("Informe seu sexo M ou F: ");
            sexo = Convert.ToChar(Console.ReadLine());

            Console.Write("Informe o seu salario: ");
            salario = Convert.ToDouble(Console.ReadLine());

            Console.ReadKey();
        }
    }
}
