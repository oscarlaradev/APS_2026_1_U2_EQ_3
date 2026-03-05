namespace Clase_ICDIA_Unidad2;

public class Ejercicio_Cantidad_Efectivo : Ejercicio
{
    private int cantidad;
    private int billeteDe1000;
    private int billeteDe500;
    private int billeteDe200;
    private int billeteDe100;
    private int billeteDe50;
    private int billeteDe20;
    private int monedaDe10;
    private int monedaDe5;
    private int monedaDe1;

    public int Cantidad
    {
        get => cantidad;
        set => cantidad = value;
    }

    public int BilleteDe1000
    {
        get => billeteDe1000;
        set => billeteDe1000 = value;
    }

    public int BilleteDe500
    {
        get => billeteDe500;
        set => billeteDe500 = value;
    }

    public int BilleteDe200
    {
        get => billeteDe200;
        set => billeteDe200 = value;
    }

    public int BilleteDe100
    {
        get => billeteDe100;
        set => billeteDe100 = value;
    }

    public int BilleteDe50
    {
        get => billeteDe50;
        set => billeteDe50 = value;
    }

    public int BilleteDe20
    {
        get => billeteDe20;
        set => billeteDe20 = value;
    }

    public int MonedaDe10
    {
        get => monedaDe10;
        set => monedaDe10 = value;
    }

    public int MonedaDe5
    {
        get => monedaDe5;
        set => monedaDe5 = value;
    }

    public int MonedaDe1
    {
        get => monedaDe1;
        set => monedaDe1 = value;
    }


    public Ejercicio_Cantidad_Efectivo(int cantidad, int billeteDe1000, int billeteDe500, int billeteDe200, int billeteDe100, int billeteDe50, int billeteDe20, int monedaDe10, int monedaDe5, int monedaDe1) : base(8,
        "Cantidad de efectivo", "Calcula la cantidad de billetes necesarios para una cantidad dada con billetes de 1000 de 500 de 200 de 100 de 50 de 20 y monedas de 10 de 5 y de 1")
    {
        Cantidad = cantidad;
        BilleteDe1000 = billeteDe1000;
        BilleteDe500 = billeteDe500;
        BilleteDe200 = billeteDe200;
        BilleteDe100 = billeteDe100;
        BilleteDe50 = billeteDe50;
        BilleteDe20 = billeteDe20;
        MonedaDe10 = monedaDe10;
        MonedaDe5 = monedaDe5;
        MonedaDe1 = monedaDe1;
    }

    public override void Ejecutar()
    {
        int cantidadRestante = Cantidad;

        BilleteDe1000 = cantidadRestante / 1000;
        cantidadRestante %= 1000;

        BilleteDe500 = cantidadRestante / 500;
        cantidadRestante %= 500;

        BilleteDe200 = cantidadRestante / 200;
        cantidadRestante %= 200;

        BilleteDe100 = cantidadRestante / 100;
        cantidadRestante %= 100;

        BilleteDe50 = cantidadRestante / 50;
        cantidadRestante %= 50;

        BilleteDe20 = cantidadRestante / 20;
        cantidadRestante %= 20;

        MonedaDe10 = cantidadRestante / 10;
        cantidadRestante %= 10;

        MonedaDe5 = cantidadRestante / 5;
        cantidadRestante %= 5;

        MonedaDe1 = cantidadRestante;

        Console.WriteLine($"Cantidad: {Cantidad}");
        Console.WriteLine($"Billetes de 1000: {BilleteDe1000}");
        Console.WriteLine($"Billetes de 500: {BilleteDe500}");
        Console.WriteLine($"Billetes de 200: {BilleteDe200}");
        Console.WriteLine($"Billetes de 100: {BilleteDe100}");
        Console.WriteLine($"Billetes de 50: {BilleteDe50}");
        Console.WriteLine($"Billetes de 20: {BilleteDe20}");
        Console.WriteLine($"Monedas de 10: {MonedaDe10}");
        Console.WriteLine($"Monedas de 5: {MonedaDe5}");
        Console.WriteLine($"Monedas de 1: {MonedaDe1}");
    }

}