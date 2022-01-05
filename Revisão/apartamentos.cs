using System;



class Program
{
    public static void Main(string[] args)
    {
        Apto x = new Apto();
        x.SetNumAndares(3);
        x.SetNumAptosAndar(2);
        int[] w = x.GetNumeros();
        foreach(int i in w) Console.WriteLine(i);

    }
}
class Apto
{
    private int numAndares;
    private int numAptosAndar;
    public void SetNumAndares(int i)
    {
        if (i > 0) numAndares = i;
    }
    public void SetNumAptosAndar(int i)
    {
        if (i > 0) numAptosAndar = i;
    }
    public int[] GetNumeros()
    {
        int[] numerodosapartamentos = new int[numAptosAndar * numAndares];           
        int apartamentos = 1;
        int numero;
        int auxiliar = 1;
        int b = 0;
        for (int i = 1; i <= numAndares; i++)
        {
            
            auxiliar = 1;
            for (int a = 1; a <= numAptosAndar; a++)
            {

                numero = apartamentos * 100 + auxiliar;
                numerodosapartamentos[b] = numero;
                auxiliar++;
                b++;
            }
            
            
            apartamentos++;
        }
        return numerodosapartamentos;
    }
}

