using System;

class Mainclass{
  public static void Main(){
    Retangulo a = new Retangulo();
    a.Base = 10;
    a.Altura = 10;
    Console.WriteLine(a.ToString());
  }
}
class Retangulo{
  private double b;
  private double h;
  public double Base{
    set { if(value > 0) b = value;}
    get {return b;}
  }
  public double Altura{
    set {if(value > 0) h = value;}
    get{return h;}  
}
public double Area{
  get {return b;}
}
public double diagonal{
  get {return Math.Sqrt((b*b)+(h*h));}
}
 public override string ToString(){
   return $"Triangulo - Base = {b} - Altura = {h}";
 }
}