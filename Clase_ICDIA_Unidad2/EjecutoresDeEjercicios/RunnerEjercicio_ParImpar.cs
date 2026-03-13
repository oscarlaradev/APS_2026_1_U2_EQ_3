using System;

namespace Clase_ICDIA_Unidad2;

public class RunnerEjercicio_ParImpar
{
    public RunnerEjercicio_ParImpar()
    {
     try
     {
         Console.WriteLine("Ingresa un número:");
         int n = int.Parse(Console.ReadLine() ?? "");

         Ejercicio ejercicio;
         ejercicio = new Ejercicio_ParImpar(n);
         ejercicio.Ejecutar();
     }
     catch (FormatException)
     {
         Console.WriteLine("Error: ingresa un número entero válido.");
     }
     catch (Exception ex)
     {
         Console.WriteLine("Error: " + ex.Message);
     }
     
    }
}