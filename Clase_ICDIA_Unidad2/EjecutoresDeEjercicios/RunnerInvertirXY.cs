namespace Clase_ICDIA_Unidad2;

public class RunnerInvertirXY
{
    public RunnerInvertirXY()
    {
        Invertir_X_Y.MostrarValoresPosibles();

        int x, y;
        Console.WriteLine("Dame el valor de x:");
        x = int.Parse(Console.ReadLine() ?? "0");
        Console.WriteLine("Dame el valor de y:");
        y = int.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine("Valores antes de invertir: x=" + x + " y=" + y);

        Invertir_X_Y ejercicio;
        ejercicio = new Invertir_X_Y(x, y);
        ejercicio.Ejecutar();

        x = ejercicio.X;
        y = ejercicio.Y;

        Console.WriteLine("Valores después de invertir: x=" + x + " y=" + y);

       
    }
    
}