using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Digite 4 numeros:");
    int[] numeros= new int[4];
    float media_aritmetica=0;
    Console.WriteLine(numeros.Length); 

    for(int i=0;i<4;i++){numeros[i] = Int32.Parse(Console.ReadLine());}

    Console.WriteLine("Datos ingresados:");
    for(int i=0;i<4;i++){
      Console.WriteLine (numeros[i]);
      media_aritmetica+=numeros[i];
    }
    media_aritmetica=media_aritmetica/numeros.Length;
    Console.WriteLine("Media aritmetica: "+media_aritmetica); 


  }
}