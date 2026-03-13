using Clase_ICDIA_Unidad2;

namespace Clase_ICDIA_Unidad2.EjecutoresEjercicio;

public class Runner_NumPrimo
{
    public Runner_NumPrimo()
    {
        try
        {
            int numero;
            Console.WriteLine("Ingrese un numero:");
            numero = int.Parse(Console.ReadLine() ?? "");

            Ejercicio ejercicio;
            ejercicio = new Ejercicio_NumPrimo(numero);
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