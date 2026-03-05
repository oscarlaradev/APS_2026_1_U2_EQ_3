namespace Clase_ICDIA_Unidad2;

public class Ejercicio_SumaAB_Generico<T> :  Ejercicio
{
    private T a;
    private T b;

    public T A { get => a; set => a = value; }
    public T B { get => b; set => b = value; }
    
    public Ejercicio_SumaAB_Generico(T a, T b) : 
        base(7, "Suma con datos genericos",
            "Suma con datos genericos")
    {
        A = a;
        B = b;
    }

    public override void Ejecutar()
    {
        //string to numero(numero o double)
        //double resultado = double.Parse(A) + double.Parse(B);
        
        double resultado = Convert.ToDouble(A) + Convert.ToDouble(B);
        
        Console.WriteLine(" La suma de A + B = " + resultado);
    }
}