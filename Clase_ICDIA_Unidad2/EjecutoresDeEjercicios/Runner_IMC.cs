namespace Clase_ICDIA_Unidad2.EjecutoresEjercicio;

public class Runner_IMC
{
    public Runner_IMC()
    {
        double[] parametros = new double[2];
        Console.WriteLine("Dame el peso: ");
        parametros[1] = double.Parse(Console.ReadLine());
        
        Console.WriteLine("Dame la altura:");
        parametros[2] = double.Parse(Console.ReadLine());
    }
}