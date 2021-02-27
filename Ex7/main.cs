using System;

class MainClass {
  public static void Main (string[] args) {
    
    string nombre;

    Console.WriteLine("Introduzca su nombre: ");
    nombre=Console.ReadLine();

    for(int i=0;i<nombre.Length;i++){
      Console.Write(nombre[i]);
      Console.Write(" ");
    }



  }
}