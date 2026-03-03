using System.Reflection;

namespace Clase_ICDIA_Unidad2;

public class Program
{
    //Entrada al programa
    public static void Main(string[] args)
    {
        Console.WriteLine("Clase_ICDIA_Unidad2");

        Console.WriteLine("Selecciona el ejercicio a ejecutar:");
        Console.WriteLine("1. Par o impar");
        Console.WriteLine("2. Suma A + B");
        Console.WriteLine("3. Invertir x y");
        int idx = int.Parse(Console.ReadLine() ?? "0");
        
        switch (idx)
        {
            case 1:
                new RunnerEjercicio_ParImpar();
                break;
            case 2:
                new RunnerSumaAB();
                break;
            case 3:
                new RunnerInvertirXY();
                break;
            default:
                Console.WriteLine("Opción no válida");
                break;
        }


    }
}