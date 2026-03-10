using Clase_ICDIA_Unidad2;

namespace Clase_ICDIA_Unidad2.EjecutoresEjercicio;

public class Runner_NumPrimo
{
    public Runner_NumPrimo()
    {
        int numero;
        Console.WriteLine("Ingrese un numero:");
        numero = Convert.ToInt32(Console.ReadLine());

        Ejercicio ejercicio;
        ejercicio = new Ejercicio_NumPrimo(numero);
        ejercicio.Ejecutar();
    }
}