using System;
using System.Numerics;

namespace Clase_ICDIA_Unidad2.EjerciciosBasicos;

public class Ejercicio_IMC<T> : Ejercicio where T : INumber<T>
{
    private T peso;
    private T estatura;

    public T Peso
    {
        get => peso;
        set => peso = value;
    }
    public T Estatura
    {
        get => estatura;
        set => estatura = value;
    }

    public Ejercicio_IMC(T peso, T estatura) : base(9, 
        "Ejercicio IMC", "Calcula IMC")
    {
        Peso = peso;
        Estatura = estatura;
    }

    public override void Ejecutar()
    {
        T resultado = Peso / (Estatura * Estatura);
        Console.WriteLine("El IMC es: " + resultado);
    }
}