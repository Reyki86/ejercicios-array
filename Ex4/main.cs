using System;

class MainClass {
  public static void Main (string[] args) {
    int[] numeros = new int[10];
    int max=0;

    Console.WriteLine("Digite 10 numeros:");
    for(int i=0;i<10;i++){
      numeros[i]=Int32.Parse(Console.ReadLine());
      if (numeros[i]>max){max=numeros[i];}
    }
    
    
    Console.WriteLine("El numero mayor es "+max);



  }
}