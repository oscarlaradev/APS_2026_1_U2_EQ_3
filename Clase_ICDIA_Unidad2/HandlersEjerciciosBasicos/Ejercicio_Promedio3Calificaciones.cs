namespace Clase_ICDIA_Unidad2;

public class Ejercicio_Promedio3Calificaciones<T> : Ejercicio
{
    private T cal1;
    private T cal2;
    private T cal3;
    
    public T Cal1 { get => cal1; set => cal1 = value; }
    public T Cal2 { get => cal2; set => cal2 = value; }
    public T Cal3 { get => cal3; set => cal3 = value; }
    
    public Ejercicio_Promedio3Calificaciones(T cal1, T cal2, T cal3) : base(11,
        "Promedio de 3 Calificaciones", "Saca el promedio ")
    {
        Cal1 = cal1;
        Cal2 = cal2;
        Cal3 = cal3;
    }
    
    public override void Ejecutar()
    {
        double resultado = (Convert.ToDouble(Cal1) + Convert.ToDouble(Cal2) + Convert.ToDouble(Cal3)) / 3;
        Console.WriteLine("El promedio es de " + resultado);
    }
}