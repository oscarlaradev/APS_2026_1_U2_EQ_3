namespace Clase_ICDIA_Unidad2;
public class Invertir_X_Y : Ejercicio
{
    public Invertir_X_Y(int x, int y) : base(3, "Invertir X Y",
        "Intercambiar el valor de dos variables (X e Y)")
    {
        this.x = x;
        this.y = y;
    }

    private int x;
    private int y;
    public int X { get => x; set => x = value; }
    public int Y { get => y; set => y = value; }

    public static void MostrarValoresPosibles()
    {
        Console.WriteLine("Valores posibles para X e Y:");
        for (int i = 1; i < 10; i++)
        {
            for (int j = 1; j < 10; j++)
            {
                Console.WriteLine(i + " " + j);
            }
        }
    }

    public override void Ejecutar()
    {
        // invertir valores X e Y
        int temp = x;
        x = y;
        y = temp;

    }
    


}