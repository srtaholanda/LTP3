using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding=Encoding.UTF8;
        Console.Write("Fala ai, seu nome: ");
        string nome = Console.ReadLine();

        Console.Write("Agora, fala ai seu sobrenome: ");
        string sobrenome = Console.ReadLine();


        string nomeCompleto = nome + " " + sobrenome;
        Console.WriteLine("Nome completo: " + nomeCompleto);
    }
}
