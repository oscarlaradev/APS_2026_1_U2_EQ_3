using Clase_ICDIA_Unidad2;
namespace Clase_ICDIA_Unidad2.EjecutoresEjercicio;

public class Runner_Promedio3Calificaciones
{
    public Runner_Promedio3Calificaciones()
    {
        double cal1, cal2, cal3;
        Console.WriteLine("Ingresa la primera calificación:");
        cal1 = double.Parse(Console.ReadLine());
        
        Console.WriteLine("Ingresa la segunda calificación");
        cal2 = double.Parse(Console.ReadLine());
        
        Console.WriteLine("Ingresa la tercera calificación:");
        cal3 = double.Parse(Console.ReadLine());
        
        Ejercicio ejercicio;
        ejercicio = new Ejercicio_Promedio3Calificaciones<double>(cal1, cal2, cal3);
        ejercicio.Ejecutar();
    }
}