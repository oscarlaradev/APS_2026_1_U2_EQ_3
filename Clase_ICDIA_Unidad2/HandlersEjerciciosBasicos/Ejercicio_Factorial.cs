namespace Clase_ICDIA_Unidad2;

using System;

public class Ejercicio_Factorial : Ejercicio
{
    private int numero;

    public int Numero
    {
        get { return numero; }
        set { numero = value; }
    }

    public Ejercicio_Factorial(int numero) : base(13,
        "Factorial",
        "Calcula el factorial de un número")
    {
        Numero = numero;
    }

    public override void Ejecutar()
    {
        int factorial = 1;

        for (int i = 1; i <= Numero; i++)
            factorial *= i;

        Console.WriteLine("El factorial de " + Numero + " es: " + factorial);
    }
}