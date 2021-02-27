using System;

class MainClass {
  public static void Main (string[] args) {
    string[] lista_personas= new string[100];

    Console.WriteLine("Introduzca los nombres de las personas (Maximo 100):");
    Console.WriteLine("Introduzca un espacio en blanco para terminar");

    for(int i=0;i<100;i++){
      lista_personas[i]=Console.ReadLine();
      
      if(lista_personas[i]==""){break;}
    }
    Console.WriteLine("Lista de personas:");
    for(int i=0;i<100;i++){Console.WriteLine(lista_personas[i]);
    if(lista_personas[i]==""){break;}
    }

}
}