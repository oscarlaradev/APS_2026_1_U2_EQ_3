using System;
namespace Clase_ICDIA_Unidad2;

public class RunnerEsMayorEdad
{
    public RunnerEsMayorEdad()
    {
        try
        {
            Console.WriteLine("Dame la edad de la persona");
            int edad = int.Parse(Console.ReadLine() ?? "");

            Ejercicio ejercicio;
            ejercicio = new Ejercicio_CompruebaMayoria_edad(edad);
            ejercicio.Ejecutar();
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: debes ingresar una edad válida.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}