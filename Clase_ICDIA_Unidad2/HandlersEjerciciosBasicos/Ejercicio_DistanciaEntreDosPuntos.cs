using System.Numerics;
using Clase_ICDIA_Unidad2.auxiliar;

namespace Clase_ICDIA_Unidad2.EjerciciosBasicos;

public class Ejercicio_DistanciaEntreDosPuntos<T> : Ejercicio where T : INumber<T>
{
    Punto<T> punto1;
    Punto<T> punto2;
    
    public Punto<T> Punto1 { get => punto1; set => punto1 = value; }
    public Punto<T> Punto2 { get => punto2; set => punto2 = value; }

    public Ejercicio_DistanciaEntreDosPuntos(T p1coordX, T p1coordY, T p2coordX, T p2coordY) : base (10, 
        "Distancia entre dos puntos", "Calcula la distancia entre dos puntos")
    {
        Punto1 = new Punto<T>(p1coordX, p1coordY);
        Punto2 = new Punto<T>(p2coordX, p2coordY);
    }

    public override void Ejecutar()
    {
        double part1 = Math.Pow(Convert.ToDouble(Punto1.CoordX - Punto2.CoordX), 2);
        double part2 = Math.Pow(Convert.ToDouble(Punto1.CoordY - Punto2.CoordY), 2);
        double resultado = Math.Sqrt(part1 + part2);
        
        Console.WriteLine($"Resultado: {resultado}");
    }
}