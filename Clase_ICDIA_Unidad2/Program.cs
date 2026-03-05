using System.Reflection;
using Clase_ICDIA_Unidad2.EjecutoresEjercicios;

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
        Console.WriteLine("4. Comprobar mayoría de edad");
        Console.WriteLine("5. A B número mayor");
        Console.WriteLine("6. Multiplicación A * B");
        Console.WriteLine("7. Suma A + B genérica");
        Console.WriteLine("8. Cantidad de efectivo");
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
            case 4:
                new RunnerEsMayorEdad();
                break;
            case 5:
                new RunnerABNumeroMayor();
                break;
            case 6:
                new RunnerMultiplicacionAB();
                break;
            case 7:
                new RunnerEjercicioABGenerico();
                break;
            case 8:
                new Runner_Cantidad_EfectivoPedido();
                break;
            default:
                Console.WriteLine("Opción no válida");
                break;
        }


    }
}