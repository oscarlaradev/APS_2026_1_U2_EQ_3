using System;
namespace Clase_ICDIA_Unidad2;

public class RunnerEsMayorEdad
{
    public RunnerEsMayorEdad()
    {
        Console.WriteLine("Dame la edad de la persona");
        int edad = int.Parse(Console.ReadLine());

        Ejercicio ejercicio;
        ejercicio = new Ejercicio_CompruebaMayoria_edad(edad);
        ejercicio.Ejecutar();
    }
}