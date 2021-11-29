using System;


class Mainclass {
public static double Maior(double x, double y){
  if (x > y){
    return x;
  } 
  else{
    return y;
  }
}

public static void Main () {
  Console.WriteLine("Escreva dois numeros");
  double a = double.Parse(Console.ReadLine());
  double b = double.Parse(Console.ReadLine());
  double maiornumero = Maior(a,b);
  Console.WriteLine($"{maiornumero}");
  

}
}