using System;

class Mainclass{
  public static void Main(){
    Triangulo a = new Triangulo();
  }
}




class Triangulo {
private double b, h;
public double Base {
get { return b; }
set { if (value >

0) b = value; }

}
public double Altura {
get { return h;}
set { if (value >

0) h = value; }

}
public double Area {
get { return b * h /
2; }

}
}