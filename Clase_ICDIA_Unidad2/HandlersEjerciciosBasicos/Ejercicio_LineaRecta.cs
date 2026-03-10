using System;
using Clase_ICDIA_Unidad2.EjecutoresEjercicios;

namespace Clase_ICDIA_Unidad2.HandlersEjerciciosBasicos;
//usando vaiables genericas T
public class Ejercicio_LineaRecta<T> : Ejercicio
{
    // y = mx + b

    private T m;
    private T b;
    private T x;

    
    public T M { get => m; set => m = value; }
    public T B { get => b; set => b = value; }
    public T X { get => x; set => x = value; }

    public Ejercicio_LineaRecta(T m, T b, T x) : base(14, "Linea Recta",
        "Calcular el valor de y en la ecuacion de la linea recta y = mx + b")
    {
        M = m;
        B = b;
        X = x;
    }

    public override void Ejecutar()
    {
        // calcular y = mx + b
        dynamic m = M;
        dynamic b = B;
        dynamic x = X;

        dynamic y = m * x + b;

        Console.WriteLine("El valor de y es: " + y);
    }
}