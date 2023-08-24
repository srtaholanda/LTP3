using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding=Encoding.UTF8;
        Console.Write("Fala ai um número: ");
        int numero = Convert.ToInt32(Console.ReadLine());
        if (numero % 2 == 0)
        {
            Console.WriteLine($"O número escolhido {numero} é PAR.");
        }
        else
        {
            Console.WriteLine($"O número escolhido {numero} é ÍMPAR.");
        }
    }
}
