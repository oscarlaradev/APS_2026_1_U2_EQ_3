using System;

namespace Clase_ICDIA_Unidad2;

public class RunnerEjercicio_ParImpar
{
    public RunnerEjercicio_ParImpar()
    {
     Console.WriteLine("Ingresa un número:");
     int n = int.Parse(Console.ReadLine() ?? "0");

     Ejercicio ejercicio;
     ejercicio = new Ejercicio_ParImpar(n);
     ejercicio.Ejecutar();
     
    }
}