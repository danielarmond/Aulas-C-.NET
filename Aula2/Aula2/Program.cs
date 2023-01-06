using System;

namespace Aula2 { 
class Program {
        static void Main(string[] args)
        {
            Console.Write("Digite seu nome completo: ");
            string nome = Console.ReadLine();
            string[] nomes = nome.Split(" ");
            string primeiro = nomes[0];
            string segundo = nomes[1];
            string terceiro = nomes[2];

            Console.WriteLine($"Seu primeiro nome é: {primeiro}");
            Console.WriteLine($"Seu segundo nome é: {segundo}");
            Console.WriteLine($"Seu terceiro nome é: {terceiro}");


        }



    }



}

