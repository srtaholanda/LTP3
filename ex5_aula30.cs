using System;

public class nomecompleto
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Insira aqui seu nome completo: ");
        string nomeUsuario = Console.ReadLine();

        Console.WriteLine("Insira aqui sua idade: "); 
        int idadeUsuario = Convert.ToInt32(Console.ReadLine()); 
        
       Console.WriteLine("Seu nome completo: " + nomeUsuario.ToUpper()); 
       Console.WriteLine("Seu nome completo: " + nomeUsuario.ToLower()); 
       string nomeSemEspacos = nomeUsuario.Replace(" ", "");
       Console.WriteLine("Seu nome tem : " + nomeSemEspacos.Length+" caracteres");
       int ano=2023 - idadeUsuario;
       int cem=ano+100;
        Console.WriteLine("Voce nasceu em "+ ano + " e completara 100 anos em " +cem );
      
    }
}