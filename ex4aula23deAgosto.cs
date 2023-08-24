using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding=Encoding.UTF8;
        Console.Write("Fala ai um número: ");
        int numero = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Tabuada do {numero}:");
        
        for (int i = 0; i <= 10; i++)
        {
            int resultado = numero * i;
            Console.WriteLine($"{numero} x {i} = {resultado}");
        }
    }
}
