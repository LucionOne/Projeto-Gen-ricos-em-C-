using System;

class Etapa2
{
    public static void Trocar<T>(ref T a, ref T b)
    {
        T temp = a;
        a = b;
        b = temp;
    }
}

class Par<T1, T2>
{
    public T1 Primeiro { get; set; }
    public T2 Segundo { get; set; }

    public void Exibir()
    {
        Console.WriteLine($"({Primeiro}, {Segundo})");
    }
}
