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
            #region Manera alternativa con objetos de tipo Ejercicio con tipo accion
            ///////////////////////////////////// manera alternativa con objetos de tipo Action
            /* Console.WriteLine("Clase_ICDIA_Unidad2");
            Console.WriteLine("Selecciona el ejercicio a ejecutar:");

            List<string> listaEjercicios = new List<string>();
            listaEjercicios.Add("1. Par o impar");
            listaEjercicios.Add("2. Suma A + B");
            listaEjercicios.Add("3. Invertir x y");
            listaEjercicios.Add("4. Comprobar mayoría de edad");
            listaEjercicios.Add("5. A B número mayor");
            listaEjercicios.Add("6. Multiplicación A * B");
            listaEjercicios.Add("7. Suma A + B genérica");
            listaEjercicios.Add("8. Cantidad de efectivo");
            listaEjercicios.Add("9. Índice de masa corporal");
            listaEjercicios.Add("10. Distancia entre dos puntos");
            listaEjercicios.Add("11. Promedio de 3 calificaciones");
            listaEjercicios.Add("12. Número primo");
            listaEjercicios.Add("13. Factorial");
            listaEjercicios.Add("14. Línea recta");
            listaEjercicios.Add("15. Perímetro de un polígono regular");
            listaEjercicios.Add("16. Lista enlazada");

            foreach (string item in listaEjercicios)
            {
                Console.WriteLine(item);
            }

            List<Action> acciones = new List<Action>();
            acciones.Add(() => new RunnerEjercicio_ParImpar());
            acciones.Add(() => new RunnerSumaAB());
            acciones.Add(() => new RunnerInvertirXY());
            acciones.Add(() => new RunnerEsMayorEdad());
            acciones.Add(() => new RunnerABNumeroMayor());
            acciones.Add(() => new RunnerMultiplicacionAB());
            acciones.Add(() => new RunnerEjercicioABGenerico());
            acciones.Add(() => new Runner_Cantidad_EfectivoPedido());
            acciones.Add(() => new Runner_IMC());
            acciones.Add(() => new Runner_DistanciaEntreDosPuntos());
            acciones.Add(() => new Runner_Promedio3Calificaciones());
            acciones.Add(() => new Runner_NumPrimo());
            acciones.Add(() => new Runner_Factorial());
            acciones.Add(() => new Runner_EjercicioLineaRecta());
            acciones.Add(() => new Runner_PerimetroPolRegular());
            acciones.Add(() => new Ej_ListaEnlazada());

            int idx = int.Parse(Console.ReadLine() ?? "");

            if (idx >= 1 && idx <= acciones.Count)
            {
                acciones[idx - 1]();
            }
            else
            {
                Console.WriteLine("Opción no válida");
            }*/

            #endregion

            #region Manera alternativa con objetos de tipo Ejercicio Coordinador
            ////////////////////////////////////////////////  Manera alternativa con objetos de tipo Ejercicio
            /*List<Ejercicio> listaEjercicios = new List<Ejercicio>();
            listaEjercicios.Add(new Ejercicio_ParImpar(5));
            listaEjercicios.Add(new Ejercicio_PerimetroPoligonoRegular<int>());

            foreach (Ejercicio item in listaEjercicios)
            {
                Console.WriteLine(item);
            }*/
            #endregion

            #region Manera tradicional con switch case
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
            Console.WriteLine("16. Lista enlazada");
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
                case 16:
                    new Ej_ListaEnlazada();
                    break;
                case 17:
                    new Lista();
                    break;
                case 18:
                    new Pokemon();
                    break;
                case 19:
                    new JuegoDado();
                    break;
                case 20:
                    new MainJuego();
                    break;
                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }
        }
            #endregion

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