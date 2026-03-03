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
        int idx = int.Parse(Console.ReadLine() ?? "0");
        
        switch (idx)
        {
            case 1:
                new RunnerEjercicio_ParImpar();
                break;
            case 2:
                new RunnerSumaAB();
                break;
        }


    }
}