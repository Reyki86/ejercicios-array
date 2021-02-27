using System;
using System.Globalization;

class MainClass {
  public static void Main (string[] args) {
    float[] numeros = new float[5];
    float promedio=0;
    int higher_cont=0;
    int lower_cont=0;


    Console.WriteLine ("Digite la altura de 5 personas:");
    for(int i=0;i<5;i++){
      numeros[i]=float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture.NumberFormat);
      promedio+=numeros[i];
    }

    promedio=promedio/numeros.Length;

    for(int i=0;i<5;i++){
      if(numeros[i]<promedio){lower_cont++;}
      if(numeros[i]>promedio){higher_cont++;}      
    }

    Console.WriteLine ("Numero de personas mas bajas que el promedio: "+lower_cont);    
    Console.WriteLine ("Numero de personas mas altas que el promedio: "+higher_cont);


  }
}