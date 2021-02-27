using System;
using System.Collections.Generic;

namespace Project
{ 
  
  public class TablaNumeros
    {
    public List<int> numeros = new List<int>();

    public void MostrarTablas(){   
      for(int i=0;i<numeros.Count;i++){
        Console.WriteLine("Tabla del "+numeros[i]);
        Console.WriteLine(numeros[i]+" x 1 = "+numeros[i]*1);
        Console.WriteLine(numeros[i]+" x 2 = "+numeros[i]*2);
        Console.WriteLine(numeros[i]+" x 3 = "+numeros[i]*3);
        Console.WriteLine(numeros[i]+" x 4 = "+numeros[i]*4);
        Console.WriteLine(numeros[i]+" x 5 = "+numeros[i]*5);
        Console.WriteLine(numeros[i]+" x 6 = "+numeros[i]*6);
        Console.WriteLine(numeros[i]+" x 7 = "+numeros[i]*7);
        Console.WriteLine(numeros[i]+" x 8 = "+numeros[i]*8);
        Console.WriteLine(numeros[i]+" x 9 = "+numeros[i]*9);
        Console.WriteLine("");
        }

      }
    }

  class Program
  {
    static void Main(string[] args)
    {
    TablaNumeros tablanumeros= new TablaNumeros();
    int num;
    

    Console.WriteLine("Digite los numeros que desee ver sus tablas (Digite -1 para terminar):");
    while (true){
      num=Int32.Parse(Console.ReadLine());
      if (num==-1){break;}
      tablanumeros.numeros.Add(num);
    }
  tablanumeros.MostrarTablas();

    

  }
  
  }

}