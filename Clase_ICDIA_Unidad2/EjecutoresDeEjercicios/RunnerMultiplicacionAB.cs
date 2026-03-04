namespace Clase_ICDIA_Unidad2;

public class RunnerMultiplicacionAB
{
    public RunnerMultiplicacionAB()
    {
        Console.Write("Ingresa A");
        int a = int.Parse(Console.ReadLine());
        
        Console.Write("Ingresa B");
        int b = int.Parse(Console.ReadLine());
        
        
        Ejercicio ejercicio;
        ejercicio = new Ejercicio_MultiplicacionAB(a,b);
        ejercicio.Ejecutar();
    }
}