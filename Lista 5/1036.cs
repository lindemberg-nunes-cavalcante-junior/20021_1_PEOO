using System;


class Mainclass {
public static void Main () {
 string valores = Console.ReadLine();
            string[] ABC = valores.Split(' ');
            double A = double.Parse(ABC[0]);
            double B = double.Parse(ABC[1]);
            double C = double.Parse(ABC[2]);
            double delta = (B * B) - 4 * A * C;
            double raizd = Math.Sqrt(delta);
            double raiz1 = ((-1 * B) + raizd) / (2 * A);
            double raiz2 = ((-1 * B) - raizd) / (2 * A);

            if (delta < 1 || A == 0) Console.WriteLine("Impossivel calcular");
            else
            {
                Console.WriteLine($"R1 = {raiz1;0.00000}");
                Console.WriteLine($"R2 = {raiz2;0.00000}");
            }

  

}
}