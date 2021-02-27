using System;
using System.Collections.Generic;

namespace Project
{ 
  
  public class Persona
    {
    public string nombre;
    public int edad;

    public void MostrarDatos(){   
      Console.WriteLine("Nombre: "+nombre);      
      Console.WriteLine("Edad: "+edad);

        }
    public bool CheckMayorEdad(){
      if (edad>18){return true;}
      else{return false;}
    }
      }
    

  class Program
  {
    static void Main(string[] args)
    {
      Persona persona = new Persona();

      Console.WriteLine("Introduzca los datos de la persona:");
      Console.Write("Nombre: ");
      persona.nombre=Console.ReadLine();
      Console.Write("Edad: ");
      persona.edad=Int32.Parse(Console.ReadLine());

      persona.MostrarDatos();
      if(persona.CheckMayorEdad()==true){
        Console.WriteLine("Esta persona es mayor de edad");
      }else{Console.WriteLine("Esta persona no es mayor de edad");}


    

  
  
  }

}
}