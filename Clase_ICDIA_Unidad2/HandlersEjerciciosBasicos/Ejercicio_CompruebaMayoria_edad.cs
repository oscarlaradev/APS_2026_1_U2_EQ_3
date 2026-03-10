namespace Clase_ICDIA_Unidad2;

public class Ejercicio_CompruebaMayoria_edad : Ejercicio
{
   private int edad;

   public int Edad
   {
      get => edad; 
      set => edad = value;
   }

   public Ejercicio_CompruebaMayoria_edad(int edad) :
      base(6, 
         "Checar Si es Ciudadano", 
         "Comprueba si dada una edad la persona es ciudadana")
   {
      Edad = edad;
   }

   public override void Ejecutar()
   {
      if (Edad >= 18)
      {
         Console.WriteLine("Es ciudadano");
      }
      else
      {
         Console.WriteLine("No es ciudadano");
      }
   }

}