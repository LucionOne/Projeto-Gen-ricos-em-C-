using System;

class Program
{
    static void Main(string[] args)
    {
        int x = 10, y = 20;
        Console.WriteLine($"Antes da troca: x = {x}, y = {y}");
        Etapa2.Trocar(ref x, ref y);
        Console.WriteLine($"Depois da troca: x = {x}, y = {y}");

        string s1 = "Hello", s2 = "World";
        Console.WriteLine($"\nAntes da troca: s1 = {s1}, s2 = {s2}");
        Etapa2.Trocar(ref s1, ref s2);
        Console.WriteLine($"Depois da troca: s1 = {s1}, s2 = {s2}");

        double d1 = 1.5, d2 = 2.5;
        Console.WriteLine($"\nAntes da troca: d1 = {d1}, d2 = {d2}");
        Etapa2.Trocar(ref d1, ref d2);
        Console.WriteLine($"Depois da troca: d1 = {d1}, d2 = {d2}");

        Par<string, int> par1 = new Par<string, int> { Primeiro = "Idade", Segundo = 30 };
        Par<string, int> par2 = new Par<string, int> { Primeiro = "Altura", Segundo = 180 };
        Console.WriteLine("\nAntes da troca de objetos:");
        par1.Exibir();
        par2.Exibir();
        Etapa2.Trocar(ref par1, ref par2);
        Console.WriteLine("Depois da troca de objetos:");
        par1.Exibir();
        par2.Exibir();
    }
}
