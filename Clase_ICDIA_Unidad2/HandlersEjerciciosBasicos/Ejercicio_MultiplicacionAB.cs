namespace Clase_ICDIA_Unidad2;

public class Ejercicio_MultiplicacionAB : Ejercicio
{
    private int a;
    private int b;

    public Ejercicio_MultiplicacionAB(int a, int b) : base (5,
        "Multiplicación A * B", "Multiplica A por B")
    {
        A = a;
        B = b;
    }

    public int A
    {
        get => a; 
        set => a = value;
    }

    public int B
    {
        get => b;
        set => b = value;
    }
    
    public override void Ejecutar()
    {
        int resultado = A * B;
        Console.WriteLine("Resultado de la multiplicación: " + 
                          resultado);
    }
}