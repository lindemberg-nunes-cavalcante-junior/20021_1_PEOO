using System;

class Mainclass{
  
      public static void Main(string[] args){
        {
            Console.WriteLine("escreva 3 numeros");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double maior = Maior(a, b, c);
            Console.WriteLine($"{maior}");

        }
        public static double Maior(double x, double y, double z)
        {
            double l;
            
            if (x > y && x > z)
            {
                return x;
            }
           
            
            if (y > x && y > z)
            {
                    return y;
            }
                
                
            if (z > x && z > y)
            {
                        return z;
            }
            else
            {
                return l = 0;
            }
                    
                


            }
        }
    }
    
  
