using Clase_ICDIA_Unidad2.EjerciciosBasicos;

namespace Clase_ICDIA_Unidad2.EjecutoresEjercicio;

public class Runner_IMC
{
    public Runner_IMC()
    {
        try
        {
            double[] parametros = new double[2];
            Console.WriteLine("Dame el peso: ");
            parametros[0] = double.Parse(Console.ReadLine() ?? "");
            
            Console.WriteLine("Dame la altura:");
            parametros[1] = double.Parse(Console.ReadLine() ?? "");

            Ejercicio ejercicio;
            ejercicio = new Ejercicio_IMC<double>(parametros[0], parametros[1]);
            ejercicio.Ejecutar();
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: debes ingresar números válidos.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}