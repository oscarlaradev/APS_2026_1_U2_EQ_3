using Clase_ICDIA_Unidad2;

namespace Clase_ICDIA_Unidad2;

public class RunnerEjercicioABGenerico
{
    public RunnerEjercicioABGenerico()
    {
        double a, b;
        Console.WriteLine("Dame el valor de a: ");
        a = double.Parse(Console.ReadLine());
        Console.WriteLine("Dame el valor de b: ");
        b = double.Parse(Console.ReadLine());

        Ejercicio ejercicio = new Ejercicio_SumaAB_Generico<double>(a, b);
        ejercicio.Ejecutar();
        
    }
    
}