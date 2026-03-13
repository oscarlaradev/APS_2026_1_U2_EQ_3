using System;

namespace Clase_ICDIA_Unidad2;
public class Runner_PerimetroPolRegular
{
    public Runner_PerimetroPolRegular()
    {
        int cantidad_lados;
        int longitud_lado;

        try
        {
            Console.WriteLine("Ingresa la cantidad de lados:");
            cantidad_lados = int.Parse(Console.ReadLine() ?? "");
            Console.WriteLine("Ingresa la longitud de un lado:");
            longitud_lado = int.Parse(Console.ReadLine() ?? "");

            Ejercicio ejercicio;
            ejercicio = new Ejercicio_PerimetroPoligonoRegular<int>(
                longitud_lado, cantidad_lados);
            ejercicio.Ejecutar();
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: debes ingresar números enteros válidos.");
        }
        catch (ArgumentException argumentException)
        {
            Console.WriteLine(argumentException.Message);
            Console.WriteLine("Un argumento no cumple las reestricciones de entrada");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        


    }
}