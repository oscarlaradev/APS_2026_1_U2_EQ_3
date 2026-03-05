namespace Clase_ICDIA_Unidad2;

public class Runner_Cantidad_EfectivoPedido
{
    public Runner_Cantidad_EfectivoPedido()
    {
        Console.Write("Ingresa la cantidad de dinero: ");
        int cantidad = int.Parse(Console.ReadLine());
        
        Ejercicio ejercicio;
        ejercicio = new Ejercicio_Cantidad_Efectivo(cantidad, 0, 0, 0, 0, 0, 0, 0, 0, 0);
        ejercicio.Ejecutar();
    }
}