using Clase_ICDIA_Unidad2;

namespace Clase_ICDIA_Unidad2.EjecutoresEjercicios;

public class RunnerABNumeroMayor
{
    public RunnerABNumeroMayor()
    {
        try
        {
            Console.Write("Ingresa A");
            int a = int.Parse(Console.ReadLine() ?? "");
            
            Console.Write("Ingresa B");
            int b = int.Parse(Console.ReadLine() ?? "");
            
            
            Ejercicio ejercicio;
            ejercicio = new EjercicioABNumeroMayor(a,b);
            ejercicio.Ejecutar();
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: debes ingresar números enteros válidos.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}