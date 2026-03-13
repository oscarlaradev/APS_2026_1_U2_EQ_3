using Clase_ICDIA_Unidad2;

namespace Clase_ICDIA_Unidad2.EjecutoresEjercicio;

public class Runner_Factorial
{
    public Runner_Factorial()
    {
        try
        {
            int n;

            Console.WriteLine("Ingresa un número:");
            n = int.Parse(Console.ReadLine() ?? "");

            Ejercicio_Factorial ejercicio = new Ejercicio_Factorial(n);
            ejercicio.Ejecutar();
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: debes ingresar un número entero válido.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}