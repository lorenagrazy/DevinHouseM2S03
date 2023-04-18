using System;

namespace ExerciciosIniciais1e2
{
  class Program
  {
    static void Main(string[] args)
    {
      int num1 = 5;
      int num2 = 10;
      double num3 = 3.14;
      double num4 = 2.71;
      double num5 = 1.618;

      Console.WriteLine($"Soma de {num1} + {num2} = {Soma(num1, num2)}");
      Console.WriteLine($"Soma de {num3} + {num4} = {Soma(num3, num4)}");
      Console.WriteLine($"Soma de {num3} + {num4} + {num5} = {Soma(num3, num4, num5)}");
    }

    static int Soma(int num1, int num2)
    {
      return num1 + num2;
    }

    static double Soma(double num1, double num2)
    {
      return num1 + num2;
    }

    static double Soma(double num1, double num2, double num3)
    {
      return num1 + num2 + num3;
    }
  }
}
