using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding=Encoding.UTF8;
        Console.Write("Fala ai um número para o primeiro valor: ");
        int valor1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Fala ai agora um número para o segundo valor: ");
        int valor2 = Convert.ToInt32(Console.ReadLine());
        
        int soma = valor1 + valor2;
        
        if (valor1 == valor2)
        {
            
            int triploDaSoma = 3 * soma;
            Console.WriteLine($"Os valores são iguais. O triplo da soma é: {triploDaSoma}");
        }
        else
        {
        
            Console.WriteLine($"A soma dos valores é: {soma}");
        }
    }
}
