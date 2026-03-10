namespace Clase_ICDIA_Unidad2;

public class Ejercicio_NumPrimo : Ejercicio
{
    private int numero;

    public int  Numero
    {
        get { return numero; }
        set { numero = value; }
    }

    public Ejercicio_NumPrimo(int numero) : base(12,
        "Numero Primo", "Identifica si un numero es primo")
    {
        Numero = numero;
    }

    public override void Ejecutar()
    {
        bool primo = true;

        for (int i = 2; i < Numero; i++)
        {
            if (Numero % i == 0)
                primo = false;
        }
        Console.WriteLine(primo ? "Es primo" : "No es primo");
    }
}