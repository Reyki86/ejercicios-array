using System;
using System.Globalization;

class MainClass {
  public static void Main (string[] args) {
    float[] numeros = new float[5];

    Console.WriteLine ("Digite 5 numeros reales:");
    for(int i=0;i<5;i++){
      numeros[i]=float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture.NumberFormat);
      }

    Console.WriteLine("Numeros en el orden contrario:");
    for(int i=4;i>-1;i--){Console.WriteLine(numeros[i]);}
  }
}