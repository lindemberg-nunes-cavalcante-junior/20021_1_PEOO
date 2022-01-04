using System;



class Program
{
    static void Main(string[] args)
    {
        int[] x = new int[10];
        int j = 0;
        do
        {
            int valor = int.Parse(Console.ReadLine());
            if (valor == 0 || valor < 0) x[j] = 1;
            else x[j] = valor;
            j++;
        } while ( j < x.Length);
        for (int i = 0; i < x.Length; i++) Console.WriteLine($"X[{i}] = {x[i]}");

    }
}
