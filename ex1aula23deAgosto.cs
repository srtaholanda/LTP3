using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding=Encoding.UTF8;
        Console.Write("Fala ai, o ano de seu nascimento: ");
        string input = Console.ReadLine();
        int anoDeNascimento = Convert.ToInt32(input);
        int anoAtual = DateTime.Now.Year;
        int idade = anoAtual - anoDeNascimento;

        // Exibe a idade no console
        Console.WriteLine($"Sua idade é: {idade} anos");
    }
}
