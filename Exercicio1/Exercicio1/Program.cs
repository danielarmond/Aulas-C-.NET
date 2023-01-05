

using System.Globalization;

namespace Exercicio1;

internal class Program
{

    static void Main(string[] args)
    {
        string produto1 = "Computador";
        string produto2 = "Mesa de escrtório";

        byte idade = 30;
        int codigo = 5290;
        char genero = 'M';

        double preco1 = 2100.0;
        double preco2 = 650.0;
        double medida = 53.232323;


        Console.WriteLine("Produtos:");
        Console.WriteLine($"{produto1}, cujo preço é ${preco1}");
        Console.WriteLine($"{produto2}, cujo preço é ${preco2}");
        Console.WriteLine();
        Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e gênero {genero}");
        Console.WriteLine();
        Console.WriteLine($"Medida com 8 casas decimais: {medida:F8}");
        Console.WriteLine($"Arredondado (três casas decimais: {medida:F3}");
        Console.WriteLine($"Separador decimal invariant culture: {medida.ToString("F3", CultureInfo.InvariantCulture)}");


    }
}