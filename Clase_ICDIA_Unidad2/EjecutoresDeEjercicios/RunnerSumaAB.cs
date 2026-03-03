namespace Clase_ICDIA_Unidad2;
public class RunnerSumaAB
{
    public RunnerSumaAB()
    {
        int a, b;
        Console.WriteLine("Dame el valor de A:");
        a = int.Parse(Console.ReadLine() ?? "0");
        Console.WriteLine("Dame el valor de B:");
        b = int.Parse(Console.ReadLine() ?? "0");

        Ejercicio ejercicio;
        ejercicio = new Ejercicio_SumaAB(a, b);
        ejercicio.Ejecutar();

    }
    
}