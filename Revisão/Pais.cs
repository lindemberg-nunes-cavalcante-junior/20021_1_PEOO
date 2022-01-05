using System;

class program{
  public static void Main(){
    Console.WriteLine("infrome o umero de paises");
    int k = int.Parse(Console.ReadLine());
    Pais[] vetor = new Pais[k];
    for(int i = 0; i < k; i++){
      Console.WriteLine("Nome:");
      string nome = Console.ReadLine();
      Console.WriteLine("N de habitantes:");
      int habs = int.Parse(Console.ReadLine());
      Console.WriteLine("Area:");
      double area = double.Parse(Console.ReadLine());
      Pais p = new Pais(nome, habs, area);
      vetor[i] = p;
    }
    foreach(Pais p in vetor){
      Console.WriteLine(p.ToString());
    }
    //Pais a = new Pais("Brasil", 209182000, 8516000);
    //Pais b = new Pais("Russia", 144526636, 17124442);
  }
}
class Pais{
  private string nome;
  private int população;
  private double area;

  public Pais(string nome, int população, double area){
    this.nome = nome;
    if(população > 0) this.população = população;
    if(area > 0) this.area = area;
  }
  public  override ToString(){
    return Console.WriteLine($"Nome: {nome} Habitantes: {população} Area: {area}");
  }
  
}