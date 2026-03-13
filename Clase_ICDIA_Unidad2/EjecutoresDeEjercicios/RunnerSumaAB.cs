namespace Clase_ICDIA_Unidad2;
public class RunnerSumaAB
{
    public RunnerSumaAB()
    {
        try
        {
            int a, b;
            Console.WriteLine("Dame el valor de A:");
            a = int.Parse(Console.ReadLine() ?? "");
            Console.WriteLine("Dame el valor de B:");
            b = int.Parse(Console.ReadLine() ?? "");

            Ejercicio ejercicio;
            ejercicio = new Ejercicio_SumaAB(a, b);
            ejercicio.Ejecutar();
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: debes ingresar números enteros válidos.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }

    }
    
}