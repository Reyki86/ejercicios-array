using System;

class MainClass {
  public static void Main (string[] args) {
    int[] DiasDeMeses= new int[] {31,28,31,30,31,30,31,31,30,31,30,31};
    int mes;

    Console.WriteLine("Digite el numero del mes:");
    mes=Int32.Parse(Console.ReadLine())-1;

    Console.WriteLine(DiasDeMeses[mes]);

  }
}