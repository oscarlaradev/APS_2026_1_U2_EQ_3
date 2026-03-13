using Clase_ICDIA_Unidad2.EjecutoresEjercicio;
using Clase_ICDIA_Unidad2.EjecutoresEjercicios;

namespace Clase_ICDIA_Unidad2;

public class Program
{
    //Entrada al programa
    public static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Clase_ICDIA_Unidad2");

            Console.WriteLine("Selecciona el ejercicio a ejecutar:");
            Console.WriteLine("1. Par o impar");
            Console.WriteLine("2. Suma A + B");
            Console.WriteLine("3. Invertir x y");
            Console.WriteLine("4. Comprobar mayoría de edad");
            Console.WriteLine("5. A B número mayor");
            Console.WriteLine("6. Multiplicación A * B");
            Console.WriteLine("7. Suma A + B genérica");
            Console.WriteLine("8. Cantidad de efectivo");
            Console.WriteLine("9. Índice de masa corporal");
            Console.WriteLine("10. Distancia entre dos puntos");
            Console.WriteLine("11. Promedio de 3 calificaciones");
            Console.WriteLine("12. Número primo");
            Console.WriteLine("13. Factorial");
            Console.WriteLine("14. Línea recta");
            Console.WriteLine("15. Perímetro de un polígono regular");
            int idx = int.Parse(Console.ReadLine() ?? "");
            
            switch (idx)
            {
                case 1:
                    new RunnerEjercicio_ParImpar();
                    break;
                case 2:
                    new RunnerSumaAB();
                    break;
                case 3:
                    new RunnerInvertirXY();
                    break;
                case 4:
                    new RunnerEsMayorEdad();
                    break;
                case 5:
                    new RunnerABNumeroMayor();
                    break;
                case 6:
                    new RunnerMultiplicacionAB();
                    break;
                case 7:
                    new RunnerEjercicioABGenerico();
                    break;
                case 8:
                    new Runner_Cantidad_EfectivoPedido();
                    break;
                case 9:
                    new Runner_IMC();
                    break;
                case 10:
                    new Runner_DistanciaEntreDosPuntos();
                    break;
                case 11:
                    new Runner_Promedio3Calificaciones();
                    break;
                case 12:
                    new Runner_NumPrimo();
                    break;
                case 13:
                    new Runner_Factorial();
                    break;
                case 14:
                    new Runner_EjercicioLineaRecta();
                    break;
                case 15:
                    new Runner_PerimetroPolRegular();
                    break;
                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: debes ingresar una opción numérica válida.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}